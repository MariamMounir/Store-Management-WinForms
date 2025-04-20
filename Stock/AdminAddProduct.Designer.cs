namespace Stock
{
    partial class AdminAddProduct
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddProduct));
            label1 = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            NUD_stock = new NumericUpDown();
            txt_price = new TextBox();
            label3 = new Label();
            btn_Add = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)NUD_stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(22, 51);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 0;
            label1.Text = "Product Name ";
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Location = new Point(197, 50);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(244, 31);
            txt_name.TabIndex = 1;
            txt_name.Validating += textBox1_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(22, 131);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 2;
            label2.Text = "Product Price";
            // 
            // NUD_stock
            // 
            NUD_stock.Location = new Point(197, 202);
            NUD_stock.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            NUD_stock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUD_stock.Name = "NUD_stock";
            NUD_stock.Size = new Size(244, 31);
            NUD_stock.TabIndex = 3;
            NUD_stock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txt_price
            // 
            txt_price.BorderStyle = BorderStyle.None;
            txt_price.Location = new Point(197, 123);
            txt_price.Multiline = true;
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(244, 31);
            txt_price.TabIndex = 4;
            txt_price.Validating += txt_price_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(22, 210);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 5;
            label3.Text = "Product Stock";
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = Color.FromArgb(58, 42, 61);
            btn_Add.Location = new Point(124, 326);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(235, 59);
            btn_Add.TabIndex = 6;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AdminAddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 42, 61);
            ClientSize = new Size(506, 450);
            Controls.Add(btn_Add);
            Controls.Add(label3);
            Controls.Add(txt_price);
            Controls.Add(NUD_stock);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminAddProduct";
            Text = "3enab";
            ((System.ComponentModel.ISupportInitialize)NUD_stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_name;
        private Label label2;
        private NumericUpDown NUD_stock;
        private TextBox txt_price;
        private Label label3;
        private Button btn_Add;
        private ErrorProvider errorProvider1;
    }
}