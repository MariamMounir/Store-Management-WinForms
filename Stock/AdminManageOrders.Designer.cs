namespace Stock
{
    partial class AdminManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageOrders));
            dg_orders = new DataGridView();
            btn_detail = new Button();
            cb_status = new ComboBox();
            btn_cahngestatus = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_orders).BeginInit();
            SuspendLayout();
            // 
            // dg_orders
            // 
            dg_orders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_orders.Dock = DockStyle.Top;
            dg_orders.Location = new Point(0, 0);
            dg_orders.Name = "dg_orders";
            dg_orders.RowHeadersWidth = 62;
            dg_orders.Size = new Size(800, 286);
            dg_orders.TabIndex = 0;
            dg_orders.SelectionChanged += dg_orders_SelectionChanged;
            // 
            // btn_detail
            // 
            btn_detail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_detail.ForeColor = Color.FromArgb(58, 42, 61);
            btn_detail.Location = new Point(34, 338);
            btn_detail.Name = "btn_detail";
            btn_detail.Size = new Size(208, 67);
            btn_detail.TabIndex = 1;
            btn_detail.Text = "Order Detail";
            btn_detail.UseVisualStyleBackColor = true;
            btn_detail.Click += btn_detail_Click;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(577, 358);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(182, 33);
            cb_status.TabIndex = 2;
            // 
            // btn_cahngestatus
            // 
            btn_cahngestatus.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cahngestatus.ForeColor = Color.FromArgb(58, 42, 61);
            btn_cahngestatus.Location = new Point(297, 338);
            btn_cahngestatus.Name = "btn_cahngestatus";
            btn_cahngestatus.Size = new Size(208, 67);
            btn_cahngestatus.TabIndex = 3;
            btn_cahngestatus.Text = "Shipp";
            btn_cahngestatus.UseVisualStyleBackColor = true;
            btn_cahngestatus.Click += btn_cahngestatus_Click;
            // 
            // AdminManageOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 42, 61);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cahngestatus);
            Controls.Add(cb_status);
            Controls.Add(btn_detail);
            Controls.Add(dg_orders);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminManageOrders";
            Text = "3enab";
            Load += AdminManageOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dg_orders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg_orders;
        private Button btn_detail;
        private ComboBox cb_status;
        private Button btn_cahngestatus;
    }
}