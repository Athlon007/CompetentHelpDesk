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

        private List<Employee> ConvertToEmployeeList(IAsyncCursor<BsonDocument> cursor)
        {
            List<Employee> list = new List<Employee>();
            foreach (var entry in cursor.ToEnumerable())
            {
                Employee employee = BsonSerializer.Deserialize<Employee>(entry);
                list.Add(employee);
            }
            return list;
        }

        public List<Employee> GetEmployees()
        {
            return ConvertToEmployeeList(employeedb.Get());
        }

        public Employee GetById(int employeeId)
        {
            Employee employee = employeedb.GetById(employeeId);
            return employee;
        }

        public Employee GetByUsername(string username)
        {
            Employee employee = employeedb.GetByUsername(username);
            return employee;
        }

        public Employee ConvertDocumentToObject(BsonDocument bsonDocument) 
        { 
            return employeedb.ConvertDocumentToObject(bsonDocument);    
        
        }
    }
}