namespace Stock
{
    partial class AdminOrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOrderDetail));
            dg_detail = new DataGridView();
            label1 = new Label();
            lb_totalPrice = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_detail).BeginInit();
            SuspendLayout();
            // 
            // dg_detail
            // 
            dg_detail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_detail.Dock = DockStyle.Top;
            dg_detail.Location = new Point(0, 0);
            dg_detail.Name = "dg_detail";
            dg_detail.RowHeadersWidth = 62;
            dg_detail.Size = new Size(693, 244);
            dg_detail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(39, 321);
            label1.Name = "label1";
            label1.Size = new Size(155, 34);
            label1.TabIndex = 1;
            label1.Text = "Total Price";
            // 
            // lb_totalPrice
            // 
            lb_totalPrice.AutoSize = true;
            lb_totalPrice.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_totalPrice.ForeColor = SystemColors.ButtonHighlight;
            lb_totalPrice.Location = new Point(82, 342);
            lb_totalPrice.Name = "lb_totalPrice";
            lb_totalPrice.Size = new Size(0, 34);
            lb_totalPrice.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(200, 321);
            label2.Name = "label2";
            label2.Size = new Size(38, 34);
            label2.TabIndex = 4;
            label2.Text = ":  ";
            // 
            // AdminOrderDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 42, 61);
            ClientSize = new Size(693, 450);
            Controls.Add(label2);
            Controls.Add(lb_totalPrice);
            Controls.Add(label1);
            Controls.Add(dg_detail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminOrderDetail";
            Text = "3enab";
            Load += AdminOrderDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dg_detail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg_detail;
        private Label label1;
        private Label lb_totalPrice;
        private Label label2;
    }
}