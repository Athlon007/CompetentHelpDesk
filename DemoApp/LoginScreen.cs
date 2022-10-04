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
using Logic;
using MongoDB.Bson;
using MongoDB.Driver;
//using MongoDB.Bson.Serialization;


namespace DemoApp
{
    public partial class LoginScreen : Form
    {
        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
        public LoginScreen()
        {
            InitializeComponent();
        }

        public EmployeesService employeeService = new EmployeesService();

        public bool CheckPasswordUsingHashedPassword(Employee employee)
        {
            bool correctPassword = false;
            return correctPassword;
        }

        public bool CheckUsernameAndPassword()
        {
            bool correctUsernameAndPassword = false;
      
            return correctUsernameAndPassword;
        }

    }
}
