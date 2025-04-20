using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using layer2_business.EntityManger;


namespace Stock
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            cb_role.Items.Add("Customer");
            cb_role.Items.Add("Admin");
            cb_role.SelectedIndex = 0;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.Trim();
            string email = txt_email.Text.Trim();
            string pass = txt_pass.Text.Trim();
            string roll = cb_role.SelectedItem.ToString();

            #region validation
            // Validation Checks
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(pass) || pass.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            bool isAdmin = roll == "Admin";
            int res = UsersManger.SignUp(name, pass, email, isAdmin);

            if (res > 0)
            {
                MessageBox.Show("Sign up successful! plz wait to activation", "Success", MessageBoxButtons.OK);
                this.Close();
            }
            else if (res == -1)
            {
                MessageBox.Show("Sign up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (res == -2)
            {
                MessageBox.Show("You already have account with that Eamil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(email, emailPattern);
        }


    }
}
