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
    public partial class AdminOrderDetail : Form
    {
        public AdminOrderDetail()
        {
            InitializeComponent();
        }
        public int OrderId {  get; set; }
        private void AdminOrderDetail_Load(object sender, EventArgs e)
        {
            dg_detail.DataSource=OrdersManger.GetOrderDetailsbyId(OrderId);
           label2.Text += OrdersManger.GetTotalPriceByOrderId(OrderId).ToString("C2");
        }
    }
}
