using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Security.Cryptography;



namespace DemoApp
{
    public partial class LoginScreen : Form
    {

        public int employeeId;
        public EmployeeService employeeService = new EmployeeService();

        public LoginScreen()
        {
            InitializeComponent();
            pnlPasswordReset.Hide();

        }

        public bool CheckPasswordUsingHashedPassword(Employee employee)
        {

            byte[] saltBytes = Convert.FromBase64String(employee.Salt);

            bool correctPassword = false;

            PasswordWithSaltHasher hasher = new PasswordWithSaltHasher();

            HashedPasswordWithSalt hashedPasswordWithSalt = hasher.HashWithSalt(txtPassword.Text, 64, SHA512.Create(), saltBytes);


            if (hashedPasswordWithSalt.HashedPassword == employee.PasswordHash)
            {
                correctPassword = true;
            }
        
          

            return correctPassword;
        }

        public bool CheckUsernameAndPassword()
        {
            bool correctUsernameAndPassword = false;

            string logInFailedMessage = "Log in failed. Please check your username and password and try again.";

            if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                throw new Exception(logInFailedMessage);
            }

            Employee employee = employeeService.GetByUsername(txtUsername.Text);
            if (employee == null)
            {
                throw new Exception(logInFailedMessage);
            }

            if (CheckPasswordUsingHashedPassword(employee) == true)
            {
                correctUsernameAndPassword = true;
            }

            else { throw new Exception(logInFailedMessage); }


            return correctUsernameAndPassword;
        }


        public void LogInUser()
        {
            
            try
            {
                bool correctUsernameAndPassword = CheckUsernameAndPassword();

                if (correctUsernameAndPassword)
                {
                    Employee employee = employeeService.GetByUsername(txtUsername.Text);
                    employeeId = employee.Id;

                    Main mainUI = new Main(employee);
                    mainUI.Show();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogInUser();
        } 

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void lblResetPassword_Click(object sender, EventArgs e)
        {
            pnlPasswordReset.Show();

        }

        public void SendResetLink()
        {

            string confirmationMessage = "";
            Employee employee = employeeService.GetByUsername(txtUsernameResetPasswordPnl.Text);

            if (txtUsernameResetPasswordPnl.Text.Length == 0 || txtEmail.Text.Length == 0)
            {
                confirmationMessage = "Password reset failed. Please fill in the username and email.";
                throw new Exception(confirmationMessage);
            }


            if (employee == null)
            {
                confirmationMessage = "This user does not exist. Please check your username and try again.";
                throw new Exception(confirmationMessage);
            }

            else
            {
                confirmationMessage = "A password reset link was sent to your email address.";
                lblLinkSent.Text = confirmationMessage;

            }

        }

        private void btnSendResetLink_Click(object sender, EventArgs e)
        {
            try { SendResetLink(); }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}
