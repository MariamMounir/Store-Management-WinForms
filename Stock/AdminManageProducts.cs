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
    public partial class AdminManageProducts : Form
    {
        public AdminManageProducts()
        {
            InitializeComponent();
        }

        private void AdminManageProducts_Load(object sender, EventArgs e)
        {
            dg_products.DataSource = ProductsManger.GetAllProduct();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form nextform = new AdminAddProduct();
            nextform.ShowDialog();

            this.Controls.Clear();
            this.InitializeComponent();
            AdminManageProducts_Load(null, null);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dg_products.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dg_products.SelectedRows[0];//object from row
            int ProductId = Convert.ToInt32(row.Cells["ProductId"].Value);
            string Name = row.Cells["Name"].Value?.ToString();
            decimal price;
            int stock = Convert.ToInt32(row.Cells["Stock"].Value);

            //validation
            //NAME
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Product name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //price
            if (!decimal.TryParse(row.Cells["Price"].Value?.ToString(), out price) || price <= 0)
            {
                MessageBox.Show("Invalid price. Enter a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //stock
            if (!int.TryParse(row.Cells["Stock"].Value?.ToString(), out stock) || stock < 0)
            {
                MessageBox.Show("Invalid stock. Enter a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int res = ProductsManger.UpdateProduct(ProductId, Name, price, stock);

            if (res > 0)
            {
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK);
                //refresh
                dg_products.DataSource = null;
                dg_products.DataSource = ProductsManger.GetAllProduct();
            }
            else
            {
                MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//refresh
                dg_products.DataSource = null;
                dg_products.DataSource = ProductsManger.GetAllProduct();
            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dg_products.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dg_products.SelectedRows[0];
            int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
            bool isDeleted = Convert.ToBoolean(row.Cells["IsDeleted"].Value);

            //conform
            string action = isDeleted ? "delete": "restore";
            DialogResult confirmResult = MessageBox.Show($"Are you sure you want to {action} this product?",
                                                         $"Confirm {action}",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.No)
            {
                return;
            }

            int res = ProductsManger.DeleteProduct(productId, isDeleted);

            if (res > 0)
            {
                MessageBox.Show($"Product successfully {action}d!", "Success", MessageBoxButtons.OK);
                //refresh
                dg_products.DataSource = null;
                dg_products.DataSource = ProductsManger.GetAllProduct();

            }
            else if (res == -2)
            {
                MessageBox.Show("Cannot delete product. It exists in a pending order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Failed to {action} product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
