using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        public int customerId { get; set; }
        public string customerName { get; set; }
        private void Customer_Load(object sender, EventArgs e)
        {
            label_username.Text = "Hello " + customerName;
        }

        private void btn_Shopping_Click(object sender, EventArgs e)
        {
            Form nextform = new CustomerShopping() { customerId = customerId };
            nextform.ShowDialog();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            Form nextform= new CustomerOrder(customerId) ;
            nextform.ShowDialog();
        }
    }
}
