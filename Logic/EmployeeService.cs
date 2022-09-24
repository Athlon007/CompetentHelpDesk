using DAL;
using Model;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Logic
{
    public class EmployeeService
    {
        IMongoCollection<BsonDocument> employees;

        public EmployeesDAO employeedb;

        public EmployeeService()
        {
            employeedb = new EmployeesDAO();
        }

        public IMongoCollection<BsonDocument> GetEmployees()
        {
            return employeedb.GetAllEmployees();
        }

        public BsonDocument GetById(string employeeId)
        {
            BsonDocument employee = employeedb.GetById(employeeId);
            return employee;
        }

     
    }
}