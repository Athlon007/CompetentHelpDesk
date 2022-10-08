using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDbConnectionNew
{
    [TestClass]
    public class TestEmployee
    {
        private EmployeeService service = new EmployeeService();

        [TestMethod]
        public void EmployeesAreNotNull()
        {
            List<Employee> employees = service.GetEmployees();
            foreach (Employee employee in employees)
            {
                Trace.WriteLine(employee);
            }
            Assert.IsNotNull(employees);
        }

        [TestMethod]
        public void GetEmployeeId0()
        {
            Employee e = service.GetById(0);
            Trace.WriteLine("Employee 0 details: " + e.ToString());
            Assert.IsNotNull(e);
        }
    }
}
