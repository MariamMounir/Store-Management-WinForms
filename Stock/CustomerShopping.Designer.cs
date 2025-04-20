namespace Stock
{
    partial class CustomerShopping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerShopping));
            dg_product = new DataGridView();
            num_quantity = new NumericUpDown();
            btn_Add = new Button();
            btn_remove = new Button();
            lb_total = new Label();
            btn_placeOrder = new Button();
            dg_order = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_order).BeginInit();
            SuspendLayout();
            // 
            // dg_product
            // 
            dg_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_product.Location = new Point(12, 12);
            dg_product.Name = "dg_product";
            dg_product.RowHeadersWidth = 62;
            dg_product.Size = new Size(502, 254);
            dg_product.TabIndex = 1;
            // 
            // num_quantity
            // 
            num_quantity.Location = new Point(347, 308);
            num_quantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_quantity.Name = "num_quantity";
            num_quantity.Size = new Size(220, 31);
            num_quantity.TabIndex = 2;
            num_quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_Add
            // 
            btn_Add.BackColor = SystemColors.Control;
            btn_Add.FlatAppearance.BorderColor = Color.FromArgb(58, 42, 61);
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = Color.FromArgb(58, 42, 61);
            btn_Add.Location = new Point(12, 285);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(151, 71);
            btn_Add.TabIndex = 6;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = SystemColors.Control;
            btn_remove.FlatAppearance.BorderColor = Color.FromArgb(58, 42, 61);
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_remove.ForeColor = Color.FromArgb(58, 42, 61);
            btn_remove.Location = new Point(12, 367);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(151, 71);
            btn_remove.TabIndex = 7;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_total.ForeColor = SystemColors.ButtonHighlight;
            lb_total.Location = new Point(210, 387);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(86, 30);
            lb_total.TabIndex = 8;
            lb_total.Text = "label1";
            // 
            // btn_placeOrder
            // 
            btn_placeOrder.BackColor = SystemColors.Control;
            btn_placeOrder.FlatAppearance.BorderColor = Color.FromArgb(58, 42, 61);
            btn_placeOrder.FlatStyle = FlatStyle.Flat;
            btn_placeOrder.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_placeOrder.ForeColor = Color.FromArgb(58, 42, 61);
            btn_placeOrder.Location = new Point(792, 317);
            btn_placeOrder.Name = "btn_placeOrder";
            btn_placeOrder.Size = new Size(220, 71);
            btn_placeOrder.TabIndex = 9;
            btn_placeOrder.Text = "Place Order";
            btn_placeOrder.UseVisualStyleBackColor = false;
            btn_placeOrder.Click += btn_placeOrder_Click_1;
            // 
            // dg_order
            // 
            dg_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_order.Location = new Point(535, 12);
            dg_order.Name = "dg_order";
            dg_order.RowHeadersWidth = 62;
            dg_order.Size = new Size(477, 254);
            dg_order.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(210, 309);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 11;
            label1.Text = "Quantity:";
            // 
            // CustomerShopping
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 42, 61);
            ClientSize = new Size(1024, 450);
            Controls.Add(label1);
            Controls.Add(dg_order);
            Controls.Add(btn_placeOrder);
            Controls.Add(lb_total);
            Controls.Add(btn_remove);
            Controls.Add(btn_Add);
            Controls.Add(num_quantity);
            Controls.Add(dg_product);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerShopping";
            Text = "3enab";
            Load += CustomerShopping_Load;
            ((System.ComponentModel.ISupportInitialize)dg_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dg_product;
        private NumericUpDown num_quantity;
        private Button btn_Add;
        private Button btn_remove;
        private Label lb_total;
        private Button btn_placeOrder;
        private DataGridView dg_order;
        private Label label1;
    }
}