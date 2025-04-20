using layer2_business.Entities;
using layer2_business.EntityManger;
using Microsoft.VisualBasic.ApplicationServices;

namespace Stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string pass = txt_pass.Text;
            Users res = UsersManger.Login(email, pass);

            if (res != null)
            {
                Form nextForm;
                if (res.IsAdmin) nextForm = new Admin() { UserName = res.Username };
                else nextForm = new Customer() { customerId = res.UserId, customerName = res.Username };



                this.Hide();
                nextForm.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
