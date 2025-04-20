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
    public partial class AdminAddProduct : Form
    {
        public AdminAddProduct()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
           // decimal pricr = decimal.Parse(txt_price.Text);
            int stock = (int)NUD_stock.Value;

            //validdation
            if (string.IsNullOrEmpty(txt_name.Text)|| !decimal.TryParse(txt_price.Text, out decimal price) || price <= 0 || string.IsNullOrEmpty(txt_price.Text))
            {
                MessageBox.Show("Miising Required Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            int res = ProductsManger.AddProduct(name, price, stock);

            if (res > 0)
            {
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Failed to add product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                errorProvider1.SetError(txt_name, "Product name cannot be empty");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_price_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(txt_price.Text, out decimal price) || price <= 0 || string.IsNullOrEmpty(txt_price.Text))
            {
                errorProvider1.SetError(txt_price, "Enter a valid price greater than 0.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        
    }
}
