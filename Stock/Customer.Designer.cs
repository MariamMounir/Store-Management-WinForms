namespace Stock
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btn_orders = new Button();
            label_username = new Label();
            btn_Shopping = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 42, 61);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 450);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 447);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_orders
            // 
            btn_orders.BackColor = Color.FromArgb(58, 42, 61);
            btn_orders.FlatAppearance.BorderColor = Color.FromArgb(58, 42, 61);
            btn_orders.FlatStyle = FlatStyle.Flat;
            btn_orders.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_orders.ForeColor = SystemColors.ButtonHighlight;
            btn_orders.Location = new Point(433, 265);
            btn_orders.Name = "btn_orders";
            btn_orders.Size = new Size(304, 71);
            btn_orders.TabIndex = 7;
            btn_orders.Text = "Your Orders";
            btn_orders.UseVisualStyleBackColor = false;
            btn_orders.Click += btn_orders_Click;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_username.ForeColor = Color.FromArgb(58, 42, 61);
            label_username.Location = new Point(459, 53);
            label_username.Name = "label_username";
            label_username.Size = new Size(86, 30);
            label_username.TabIndex = 6;
            label_username.Text = "label1";
            // 
            // btn_Shopping
            // 
            btn_Shopping.BackColor = Color.FromArgb(58, 42, 61);
            btn_Shopping.FlatAppearance.BorderColor = Color.FromArgb(58, 42, 61);
            btn_Shopping.FlatStyle = FlatStyle.Flat;
            btn_Shopping.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Shopping.ForeColor = SystemColors.ButtonHighlight;
            btn_Shopping.Location = new Point(433, 149);
            btn_Shopping.Name = "btn_Shopping";
            btn_Shopping.Size = new Size(304, 71);
            btn_Shopping.TabIndex = 5;
            btn_Shopping.Text = "Shopping";
            btn_Shopping.UseVisualStyleBackColor = false;
            btn_Shopping.Click += btn_Shopping_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_orders);
            Controls.Add(label_username);
            Controls.Add(btn_Shopping);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Customer";
            Text = "3enab";
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_orders;
        private Label label_username;
        private Button btn_Shopping;
    }
}