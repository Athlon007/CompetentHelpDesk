using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using DAL;

namespace Logic
{
    public class EmployeeService
    {
        private EmployeesDAO employeedb;

        public EmployeeService()
        {
            employeedb = new EmployeesDAO();
        }

        public List<Employee> GetEmployees()
        {
            return employeedb.GetAllEmployees().AsQueryable().ToList();
        }

        public Employee GetById(int employeeId)
        {
            Employee employee = employeedb.GetById(employeeId);
            return employee;
        }

        public Employee ConvertDocumentToObject(BsonDocument bsonDocument) 
        { 
            return employeedb.ConvertDocumentToObject(bsonDocument);    
        
        }
    }
}