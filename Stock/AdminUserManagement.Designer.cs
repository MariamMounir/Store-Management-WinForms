namespace Stock
{
    partial class AdminUserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserManagement));
            dg_users = new DataGridView();
            btn_activate = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_users).BeginInit();
            SuspendLayout();
            // 
            // dg_users
            // 
            dg_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_users.Location = new Point(30, 23);
            dg_users.Name = "dg_users";
            dg_users.RowHeadersWidth = 62;
            dg_users.Size = new Size(744, 321);
            dg_users.TabIndex = 0;
            dg_users.CellValueChanged += dg_users_CellValueChanged;
            // 
            // btn_activate
            // 
            btn_activate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_activate.ForeColor = Color.FromArgb(58, 42, 61);
            btn_activate.Location = new Point(307, 362);
            btn_activate.Name = "btn_activate";
            btn_activate.Size = new Size(211, 64);
            btn_activate.TabIndex = 1;
            btn_activate.Text = "Action";
            btn_activate.UseVisualStyleBackColor = true;
            // 
            // AdminUserManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 42, 61);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_activate);
            Controls.Add(dg_users);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminUserManagement";
            Text = "3enab";
            Load += AdminUserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dg_users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg_users;
        private Button btn_activate;
    }
}