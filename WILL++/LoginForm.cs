using System;
using System.Windows.Forms;
using WIL__;

namespace WILL__
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your email and password.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                UserRepository userRepository = new UserRepository();

                bool loginSuccessful = userRepository.Login(email, password);

                if (loginSuccessful)
                {
                    MessageBox.Show(
                        "Login successful!",
                        "WIL++",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    StudentDashboard dashboard = new StudentDashboard();
                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Invalid email or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to connect to the database.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnCreateAccount_Click (object sender, EventArgs e)
        {
            MessageBox.Show("Create Account screen coming soon");
        }


    }
}
