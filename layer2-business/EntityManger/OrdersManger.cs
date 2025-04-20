using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer1_connection;
using layer2_business.Entities;
using layer2_business.EntityList;

namespace layer2_business.EntityManger
{
    public class OrdersManger
    {
        static DBManger storeDB = new DBManger();

        //create order => customer
        public static int createOrder(int userId, OrderDetailsList orderDetail)
        {
            try
            {
                //check item lenght
                if (orderDetail == null || orderDetail.Count == 0)
                {
                    Console.WriteLine("Order must contain at least one product.");
                    return -2;
                }

                Dictionary<string, object> dic = new Dictionary<string, object>
                {
                    {"p1",userId},
                    {"p2",OrderStatus.Pending.ToString() }
                };
                //insert order and get orderId
                object result = storeDB.ExecuteScalar("Insert into orders (UserId,Status) output INSERTED.OrderId values(@p1,@p2)", dic);

                if (result == null || !int.TryParse(result.ToString(), out int orderId))
                {
                    return -3;
                }


                //insert order detail
                foreach (var detail in orderDetail)
                {
                    Dictionary<string, object> param = new Dictionary<string, object>
                    {
                        {"p1",orderId },
                        {"p2",detail.ProductId},
                        {"p3",detail.Quantity},
                        {"p4",detail.Price}
                    };
                    storeDB.ExecuteNonQuery("Insert into OrderDetails(OrderId,ProductId,Quantity,Price) values(@p1,@p2,@p3,@p4)", param);

                    //update stock
                    // decrese stock from Products table
                    Dictionary<string, object> stockParam = new Dictionary<string, object>
                    {
                         {"p1", detail.Quantity},
                         {"p2", detail.ProductId}
                     };

                    storeDB.ExecuteNonQuery("UPDATE Products SET Stock = Stock - @p1 WHERE ProductId = @p2 AND Stock >= @p1", stockParam);

                }
                return 1;


            }
            catch (Exception e) 
            {
                Console.WriteLine("Error creating order: " + e.Message);
                return -1;
            }
        }

        //changing order stat
        public static int ChangeOrderStatus(int orderId, OrderStatus newStatus)
        {
            try
            {
                Dictionary<string, object> dic = new Dictionary<string, object>
                {
                    { "p1", orderId },
                    { "p2", newStatus.ToString() }
                };
                return storeDB.ExecuteNonQuery("update orders set Status=@p2 where OrderId=@p1", dic);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error changing order status: " + e.Message);
                return -1;
            }
        }
        //getall order 
        public static OrdersList GetAllOrders()
        {
            try
            {
                DataTable dt = storeDB.ExecuteDataTable("Select * from Orders");
                return FromDataTableToOrdertList(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error fetching orders: " + e.Message);
                return new OrdersList();
            }
        }
        //get order by id =>customer
        public static OrdersList GetOrderById(int customerID)
        {
            try
            {
                Dictionary<string, object> dic = new Dictionary<string, object>
                {
                    {"p1",customerID}
                };
                DataTable dt = storeDB.ExecuteDataTable("Select * from Orders where UserId=@p1",dic);
                return FromDataTableToOrdertList(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error fetching orders: " + e.Message);
                return new OrdersList();
            }
        }
        //getall order detail by id
        public static OrderDetailsList GetOrderDetailsbyId(int orderId)
        {
            try
            {
                Dictionary<string, object> dic = new Dictionary<string, object>
                {
                    {"p1",orderId}
                };
                DataTable dt = storeDB.ExecuteDataTable("select * from OrderDetails where OrderId=@p1", dic);
                return FromDataTableToOrderDetailtList(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error fetching order details: " + e.Message);
                return new OrderDetailsList();
            }
        }
        //get order totalprice by orderid
        public static decimal GetTotalPriceByOrderId(int orderId)
        {
            try
            {
                Dictionary<string, object> dic = new Dictionary<string, object>{{ "p1", orderId }};

               string query = "SELECT ISNULL(SUM(Quantity * Price), 0) AS TotalPrice FROM OrderDetails WHERE OrderId = @p1";

                object result = storeDB.ExecuteScalar(query, dic);

               return result != null ? Convert.ToDecimal(result) : 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error fetching total price: " + e.Message);
                return -1;
            }
        }
        //transform order
        internal static OrdersList FromDataTableToOrdertList(DataTable dt)
        {
            OrdersList orderList = new OrdersList();
            foreach (DataRow dr in dt.Rows)
            {
                Orders order = FromDataRowToOrder(dr);
                orderList.Add(order);
            }
            return orderList;
        }
        internal static Orders FromDataRowToOrder(DataRow dr)
        {
            Orders order = new Orders();

            if (int.TryParse(dr["OrderId"]?.ToString() ?? "-1", out int orderId))
                order.OrderId = orderId;

            if (int.TryParse(dr["UserId"]?.ToString() ?? "-1", out int userId))
                order.UserId = userId;

            if (Enum.TryParse(dr["Status"]?.ToString(), out OrderStatus status))
                order.Status = status;//enum

            return order;
        }
        //transform orderDetail
        internal static OrderDetailsList FromDataTableToOrderDetailtList(DataTable dt)
        {
            OrderDetailsList orderdetailList = new OrderDetailsList();
            foreach (DataRow dr in dt.Rows)
            {
                OrderDetails order = FromDataRowToOrderDetail(dr);
                orderdetailList.Add(order);
            }
            return orderdetailList;
        }
        internal static OrderDetails FromDataRowToOrderDetail(DataRow dr)
        {
            OrderDetails detail = new OrderDetails();

            if (int.TryParse(dr["OrderDetailId"]?.ToString() ?? "-1", out int orderDetailId))
                detail.OrderDetailId = orderDetailId;

            if (int.TryParse(dr["OrderId"]?.ToString() ?? "-1", out int orderId))
                detail.OrderId = orderId;

            if (int.TryParse(dr["ProductId"]?.ToString() ?? "-1", out int productId))
                detail.ProductId = productId;

            if (int.TryParse(dr["Quantity"]?.ToString() ?? "-1", out int quantity))
                detail.Quantity = quantity;

            if (decimal.TryParse(dr["Price"]?.ToString() ?? "-1", out decimal price))
                detail.Price = price;

            return detail;
        }
    }
}
