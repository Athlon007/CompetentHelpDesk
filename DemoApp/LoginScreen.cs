using Logic;
using Model;
using System;
using System.Windows.Forms;



namespace DemoApp
{
    public partial class LoginScreen : Form
    {

        public int employeeId;
        public EmployeeService employeeService = new EmployeeService();
        public LoginService loginService = new LoginService();
        public LoginScreen()
        {
            InitializeComponent();
        }


        public void LogInUser()
        {
            try
            {
                bool correctUsernameAndPassword = loginService.CheckUsernameAndPassword(txtUsername.Text, txtPassword.Text);

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

    }
}
