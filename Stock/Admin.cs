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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public string UserName { get; set; }
        private void Admin_Load(object sender, EventArgs e)
        {
            label_username.Text = "Hello " + UserName;
        }

        private void btn_activation_Click(object sender, EventArgs e)
        {
            Form nextform = new AdminUserManagement();
            nextform.ShowDialog();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            Form nextForm = new AdminManageProducts();
            nextForm.ShowDialog();
        }

        private void btn_oreder_Click(object sender, EventArgs e)
        {
            Form nextForm= new AdminManageOrders();
            nextForm.ShowDialog();
        }
    }
}
