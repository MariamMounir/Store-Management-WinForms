using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using layer2_business.EntityManger;

namespace Stock
{
    public partial class CustomerOrder : Form
    {
        public int CustomerId { get; set; }
        public CustomerOrder(int customerId)
        {
            InitializeComponent();
            CustomerId = customerId;
        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            dg_order.DefaultCellStyle.ForeColor = Color.Black;
            dg_order.DefaultCellStyle.BackColor = Color.White;
            dg_order.DataSource = OrdersManger.GetOrderById(CustomerId);
            btn_detail.Enabled = false;
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            int orderId = 0;
            if (dg_order.SelectedRows.Count > 0)
            {
                orderId = Convert.ToInt32(dg_order.SelectedRows[0].Cells["OrderId"].Value);
                MessageBox.Show($"Selected Order ID: {orderId}");
            }
            Form nextForm = new AdminOrderDetail() { OrderId = orderId };
            nextForm.ShowDialog();
        }

        private void dg_order_SelectionChanged(object sender, EventArgs e)
        {
            btn_detail.Enabled = dg_order.SelectedRows.Count == 1;
        }
    }
}
