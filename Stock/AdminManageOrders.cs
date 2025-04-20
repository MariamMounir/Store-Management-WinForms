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
using layer2_business.EntityManger;

namespace Stock
{
    public partial class AdminManageOrders : Form
    {
        public AdminManageOrders()
        {
            InitializeComponent();
        }

        private void AdminManageOrders_Load(object sender, EventArgs e)
        {
            dg_orders.DataSource = OrdersManger.GetAllOrders();
            btn_detail.Enabled = false;
            cb_status.DataSource = Enum.GetValues(typeof(OrderStatus));
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            int orderId = 0;
            if (dg_orders.SelectedRows.Count > 0)
            {
                orderId = Convert.ToInt32(dg_orders.SelectedRows[0].Cells["OrderId"].Value);
                MessageBox.Show($"Selected Order ID: {orderId}");
            }
            Form nextForm = new AdminOrderDetail() { OrderId = orderId };
            nextForm.ShowDialog();
        }

        private void dg_orders_SelectionChanged(object sender, EventArgs e)
        {
            btn_detail.Enabled = dg_orders.SelectedRows.Count == 1;
        }

        private void btn_cahngestatus_Click(object sender, EventArgs e)
        {
            if (dg_orders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            int orderId = Convert.ToInt32(dg_orders.SelectedRows[0].Cells["OrderId"].Value);

            
            OrderStatus currentStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), dg_orders.SelectedRows[0].Cells["Status"].Value.ToString());

            
            if (currentStatus != OrderStatus.Pending)
            {
                MessageBox.Show("Only pending orders can be updated.");
                return;
            }

            
            OrderStatus newStatus = (OrderStatus)cb_status.SelectedItem;

            
            int result = OrdersManger.ChangeOrderStatus(orderId, newStatus);

            if (result > 0)
            {
                MessageBox.Show("Order status updated successfully.");

               
                dg_orders.DataSource = OrdersManger.GetAllOrders();
            }
            else
            {
                MessageBox.Show("Failed to update order status.");
            }
        }

        
    }
}
