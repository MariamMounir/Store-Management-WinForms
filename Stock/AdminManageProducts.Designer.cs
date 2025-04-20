namespace Stock
{
    partial class AdminManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageProducts));
            dg_products = new DataGridView();
            btn_Add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_products).BeginInit();
            SuspendLayout();
            // 
            // dg_products
            // 
            dg_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_products.Dock = DockStyle.Top;
            dg_products.Location = new Point(0, 0);
            dg_products.Name = "dg_products";
            dg_products.RowHeadersWidth = 62;
            dg_products.Size = new Size(800, 255);
            dg_products.TabIndex = 0;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = SystemColors.Control;
            btn_Add.BackgroundImageLayout = ImageLayout.None;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = Color.FromArgb(58, 42, 61);
            btn_Add.Location = new Point(42, 315);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(190, 74);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "Add Product";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.Control;
            btn_update.BackgroundImageLayout = ImageLayout.None;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.FromArgb(58, 42, 61);
            btn_update.Location = new Point(297, 315);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(188, 74);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update Product";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.Control;
            btn_delete.BackgroundImageLayout = ImageLayout.None;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.FromArgb(58, 42, 61);
            btn_delete.Location = new Point(550, 315);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(188, 74);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete Product";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // AdminManageProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 42, 61);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_Add);
            Controls.Add(dg_products);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminManageProducts";
            Text = "3enab";
            Load += AdminManageProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dg_products).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg_products;
        private Button btn_Add;
        private Button btn_update;
        private Button btn_delete;
    }
}