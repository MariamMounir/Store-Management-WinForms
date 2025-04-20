using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using layer2_business.Entities;
using layer2_business.EntityList;
using layer2_business.EntityManger;

namespace Stock
{
    public partial class CustomerShopping : Form
    {
        private OrderDetailsList orderlist = new OrderDetailsList();

        public int customerId { get; set; }
        public CustomerShopping()
        {
            InitializeComponent();
        }

        private void CustomerShopping_Load(object sender, EventArgs e)
        {
            ProductsList allproduct = ProductsManger.GetAllProduct();
            //filter 
            var filterproduct = allproduct.Where(p => !p.IsDeleted).ToList();
            //display
            dg_product.DataSource = filterproduct;
            //hide column in products
            dg_product.Columns["IsDeleted"].Visible = false;
            dg_product.Columns["ProductId"].Visible = false;
            //add column to cart
            dg_order.Columns.Add("ProductId", "Product ID");
            dg_order.Columns.Add("ProductName", "Product Name");
            dg_order.Columns.Add("Quantity", "Quantity");
            dg_order.Columns.Add("Price", "Price");
            // Format price columns
            dg_order.Columns["Price"].DefaultCellStyle.Format = "C2";
            //hide
            dg_order.Columns["ProductId"].Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (dg_product.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            int productId = Convert.ToInt32(dg_product.SelectedRows[0].Cells["ProductId"].Value);
            string productName = dg_product.SelectedRows[0].Cells["Name"].Value.ToString();
            decimal price = Convert.ToDecimal(dg_product.SelectedRows[0].Cells["Price"].Value);
            int Stock = Convert.ToInt32(dg_product.SelectedRows[0].Cells["Stock"].Value);
            int quantity = (int)num_quantity.Value;

            //validation
            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            // Check if quantity exceeds stock
            if (quantity > Stock)
            {
                MessageBox.Show("Not enough stock available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //display in cart

            foreach (DataGridViewRow row in dg_order.Rows)
            {
                if (Convert.ToInt32(row.Cells["ProductId"].Value) == productId)
                {
                    int existingQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                    int newQty = existingQty + quantity;

                    if (newQty > Stock)
                    {
                        MessageBox.Show("Not enough stock available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    row.Cells["Quantity"].Value = newQty;
                    row.Cells["Price"].Value = price * newQty;

                    // **Update orderlist too**
                    var existingOrder = orderlist.FirstOrDefault(o => o.ProductId == productId);
                    if (existingOrder != null)
                    {
                        existingOrder.Quantity = newQty;
                        existingOrder.Price = price * newQty;
                    }
                    UpdateTotalPrice();


                    return;
                }
            }
            //add product to list
            OrderDetails order = new OrderDetails()
            {
                ProductId = productId,
                Quantity = quantity,
                Price = price * quantity,
            };
            UpdateTotalPrice();
            orderlist.Add(order);
            dg_order.Rows.Add(productId, productName, quantity, price);

        }
        private void UpdateTotalPrice()
        {
            decimal total = 0;
            int quantity = 0;
            decimal price = 0;
            foreach (DataGridViewRow row in dg_order.Rows)
            {
                quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                price = Convert.ToDecimal(row.Cells["Price"].Value);
                total += quantity * price;
            }
           
            lb_total.Text = total.ToString("C2");
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dg_order.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            int selectedProductId = Convert.ToInt32(dg_order.SelectedRows[0].Cells["ProductId"].Value);

            // Remove from DataGridView
            dg_order.Rows.RemoveAt(dg_order.SelectedRows[0].Index);

            // Remove from Order List
            var orderToRemove = orderlist.FirstOrDefault(o => o.ProductId == selectedProductId);
            orderlist.Remove(orderToRemove);


            UpdateTotalPrice();
        }

        private void btn_placeOrder_Click_1(object sender, EventArgs e)
        {
            if (orderlist.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add products before placing an order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            int success = OrdersManger.createOrder(customerId, orderlist);

            if (success > 0)
            {
                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK);


                orderlist.Clear();
                dg_order.Rows.Clear();
                UpdateTotalPrice();


                CustomerShopping_Load(null, null);
            }
            else
            {
                MessageBox.Show("Error placing order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
