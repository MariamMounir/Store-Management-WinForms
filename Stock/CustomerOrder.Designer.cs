namespace Stock
{
    partial class CustomerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrder));
            btn_detail = new Button();
            dg_order = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg_order).BeginInit();
            SuspendLayout();
            // 
            // btn_detail
            // 
            btn_detail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_detail.ForeColor = Color.FromArgb(58, 42, 61);
            btn_detail.Location = new Point(278, 340);
            btn_detail.Name = "btn_detail";
            btn_detail.Size = new Size(246, 67);
            btn_detail.TabIndex = 2;
            btn_detail.Text = "Order Detail";
            btn_detail.UseVisualStyleBackColor = true;
            btn_detail.Click += btn_detail_Click;
            // 
            // dg_order
            // 
            dg_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_order.Dock = DockStyle.Top;
            dg_order.Location = new Point(0, 0);
            dg_order.Name = "dg_order";
            dg_order.RowHeadersWidth = 62;
            dg_order.Size = new Size(800, 262);
            dg_order.TabIndex = 3;
            dg_order.SelectionChanged += dg_order_SelectionChanged;
            // 
            // CustomerOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 42, 61);
            ClientSize = new Size(800, 450);
            Controls.Add(dg_order);
            Controls.Add(btn_detail);
            ForeColor = SystemColors.ControlLightLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerOrder";
            Text = "3enab";
            Load += CustomerOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dg_order).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_detail;
        private DataGridView dg_order;
    }
}