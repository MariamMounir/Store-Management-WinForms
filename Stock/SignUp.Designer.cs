namespace Stock
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            txt_name = new TextBox();
            txt_email = new TextBox();
            txt_pass = new TextBox();
            cb_role = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_SignUp = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Location = new Point(413, 67);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Enter Your name";
            txt_name.Size = new Size(255, 37);
            txt_name.TabIndex = 0;
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Location = new Point(413, 169);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Enter Your Email";
            txt_email.Size = new Size(255, 38);
            txt_email.TabIndex = 1;
            // 
            // txt_pass
            // 
            txt_pass.BorderStyle = BorderStyle.None;
            txt_pass.Location = new Point(413, 265);
            txt_pass.Multiline = true;
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(255, 37);
            txt_pass.TabIndex = 2;
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(413, 374);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(255, 33);
            cb_role.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(58, 42, 61);
            label1.Location = new Point(413, 30);
            label1.Name = "label1";
            label1.Size = new Size(99, 34);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(58, 42, 61);
            label2.Location = new Point(413, 132);
            label2.Name = "label2";
            label2.Size = new Size(88, 34);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(58, 42, 61);
            label3.Location = new Point(413, 228);
            label3.Name = "label3";
            label3.Size = new Size(143, 34);
            label3.TabIndex = 6;
            label3.Text = "Passward";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(58, 42, 61);
            label4.Location = new Point(413, 337);
            label4.Name = "label4";
            label4.Size = new Size(65, 34);
            label4.TabIndex = 7;
            label4.Text = "role";
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.FromArgb(58, 42, 61);
            btn_SignUp.FlatAppearance.BorderColor = Color.FromArgb(58, 42, 61);
            btn_SignUp.FlatStyle = FlatStyle.Flat;
            btn_SignUp.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SignUp.ForeColor = SystemColors.ButtonHighlight;
            btn_SignUp.Location = new Point(413, 448);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(255, 51);
            btn_SignUp.TabIndex = 8;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = false;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 42, 61);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 535);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 532);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 535);
            Controls.Add(panel1);
            Controls.Add(btn_SignUp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_role);
            Controls.Add(txt_pass);
            Controls.Add(txt_email);
            Controls.Add(txt_name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUp";
            Text = "3enab";
            Load += SignUp_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_email;
        private TextBox txt_pass;
        private ComboBox cb_role;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_SignUp;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}