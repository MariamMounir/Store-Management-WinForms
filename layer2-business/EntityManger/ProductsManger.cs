using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer1_connection;
using layer2_business.Entities;
using layer2_business.EntityList;

namespace layer2_business.EntityManger
{
    public class ProductsManger
    {
        static DBManger storeDB = new DBManger();
        //add product
        public static int AddProduct(string name, decimal price, int stock)
        {
            try
            {
                Dictionary<string, object> dic = new Dictionary<string, object>
                {
                    {"p1",name},
                    {"p2",price},
                    {"p3",stock},
                    {"p4",false}
                };

                return storeDB.ExecuteNonQuery("Insert Into Products (Name,Price,Stock,IsDeleted) Values(@p1,@p2,@p3,@p4)", dic);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding product: " + ex.Message);
                return -1;
            }
        }
        //update product 
        public static int UpdateProduct(int id, string name, decimal price, int stock)
        {
            try
            {
                Dictionary<string, object> dic = new Dictionary<string, object>
                {
                    {"p1",id },
                    {"p2",name},
                    {"p3",price},
                    {"p4",stock},
                    {"p5",false}
                };
                return storeDB.ExecuteNonQuery("update products set Name=@p2,Price=@p3,Stock=@p4 where ProductId=@p1", dic);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating product: " + ex.Message);
                return -1;
            }
        }
        //delete product (handel order in this case)
        public static int DeleteProduct(int productId, bool status)
        {
            try
            {
                //check if product is in order panding 
                Dictionary<string, object> chk = new Dictionary<string, object> { { "p1", productId }, };
                DataTable dt = storeDB.ExecuteDataTable("SELECT * FROM OrderDetails od JOIN Orders o ON od.OrderId = o.OrderId WHERE od.ProductId = @p1 AND o.Status = 'Pending'", chk);
                if(dt.Rows.Count > 0)
                {
                    Console.WriteLine("Cannot delete product. It exists in a pending order.");
                    return -2;
                }
                

                Dictionary<string, object> dic = new Dictionary<string, object>
                {
                    {"p1",productId },
                    {"p2",status }

                };
                return storeDB.ExecuteNonQuery("update products set IsDeleted=@p2  where ProductId=@p1", dic);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting product: " + ex.Message);
                return -1;
            }
        }
        //see all product
        public static ProductsList GetAllProduct()
        {
            try
            {
                DataTable dt = storeDB.ExecuteDataTable("select * from Products");
                var res = FromDataTableToProductList(dt);
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching products: " + ex.Message);
                return new ProductsList();
            }

        }
        //transform
        internal static ProductsList FromDataTableToProductList(DataTable dt)
        {
            ProductsList productList = new ProductsList();
            foreach (DataRow dr in dt.Rows)
            {
                Products product = FromDataRowToProduct(dr);
                productList.Add(product);
            }
            return productList;
        }
        internal static Products FromDataRowToProduct(DataRow dr)
        {
            Products product = new Products();

            if (int.TryParse(dr["ProductId"]?.ToString() ?? "-1", out int productId))
                product.ProductId = productId;

            product.Name = dr["Name"]?.ToString() ?? "Unknown";

            if (decimal.TryParse(dr["Price"]?.ToString() ?? "-1", out decimal price))
                product.Price = price;

            if (int.TryParse(dr["Stock"]?.ToString() ?? "-1", out int stock))
                product.Stock = stock;

            if (bool.TryParse(dr["IsDeleted"]?.ToString(), out bool IsDeleted))
                product.IsDeleted = IsDeleted;

            return product;
        }

        
    }
}
