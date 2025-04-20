using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layer1_connection;
using layer2_business.EntityManger;

namespace Stock
{
    public partial class AdminUserManagement : Form
    {
        public AdminUserManagement()
        {
            InitializeComponent();
        }

        private void AdminUserManagement_Load(object sender, EventArgs e)
        {
            dg_users.DataSource = UsersManger.GetAllUsers();


        }

        private void dg_users_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_users.Columns[e.ColumnIndex].Name=="IsActive"&&e.RowIndex>=0)
            {
                int userId = Convert.ToInt32(dg_users.Rows[e.RowIndex].Cells["UserId"].Value);
                bool newStatus = Convert.ToBoolean(dg_users.Rows[e.RowIndex].Cells["IsActive"].Value);

                DialogResult dialog = MessageBox.Show($"Are you sure you want to {(newStatus ? "activeate" : "deactivate")} this user?", "Conferm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes) 
                {
                    int updatesuccess = UsersManger.ActivateUser(userId, newStatus);
                    if (updatesuccess < 0) 
                    {
                        MessageBox.Show("Failed to update user status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dg_users.Rows[e.RowIndex].Cells["IsActive"].Value = !newStatus;
                    }
                }
                else 
                {
                    dg_users.Rows[e.RowIndex].Cells["IsActive"].Value = !newStatus;
                }
            }
        }
    }
}
