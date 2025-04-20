namespace Stock
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btn_activation = new Button();
            label_username = new Label();
            btn_products = new Button();
            btn_oreder = new Button();
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
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 444);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_activation
            // 
            btn_activation.BackColor = Color.FromArgb(58, 42, 61);
            btn_activation.FlatAppearance.BorderColor = Color.FromArgb(58, 42, 61);
            btn_activation.FlatStyle = FlatStyle.Flat;
            btn_activation.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_activation.ForeColor = SystemColors.ButtonHighlight;
            btn_activation.Location = new Point(445, 112);
            btn_activation.Name = "btn_activation";
            btn_activation.Size = new Size(304, 71);
            btn_activation.TabIndex = 1;
            btn_activation.Text = "User Activation";
            btn_activation.UseVisualStyleBackColor = false;
            btn_activation.Click += btn_activation_Click;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_username.ForeColor = Color.FromArgb(58, 42, 61);
            label_username.Location = new Point(471, 47);
            label_username.Name = "label_username";
            label_username.Size = new Size(86, 30);
            label_username.TabIndex = 2;
            label_username.Text = "label1";
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.FromArgb(58, 42, 61);
            btn_products.FlatAppearance.BorderColor = Color.FromArgb(58, 42, 61);
            btn_products.FlatStyle = FlatStyle.Flat;
            btn_products.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_products.ForeColor = SystemColors.ButtonHighlight;
            btn_products.Location = new Point(445, 209);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(304, 71);
            btn_products.TabIndex = 3;
            btn_products.Text = "Manage Products";
            btn_products.UseVisualStyleBackColor = false;
            btn_products.Click += btn_products_Click;
            // 
            // btn_oreder
            // 
            btn_oreder.BackColor = Color.FromArgb(58, 42, 61);
            btn_oreder.FlatAppearance.BorderColor = Color.FromArgb(58, 42, 61);
            btn_oreder.FlatStyle = FlatStyle.Flat;
            btn_oreder.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_oreder.ForeColor = SystemColors.ButtonHighlight;
            btn_oreder.Location = new Point(445, 307);
            btn_oreder.Name = "btn_oreder";
            btn_oreder.Size = new Size(304, 71);
            btn_oreder.TabIndex = 4;
            btn_oreder.Text = "Manage Orders";
            btn_oreder.UseVisualStyleBackColor = false;
            btn_oreder.Click += btn_oreder_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_oreder);
            Controls.Add(btn_products);
            Controls.Add(label_username);
            Controls.Add(btn_activation);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin";
            Text = "3enab";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_activation;
        private Label label_username;
        private Button btn_products;
        private Button btn_oreder;
    }
}