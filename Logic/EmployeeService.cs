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

        public EmployeeDAO employeedb;

        public EmployeeService()
        {
            employeedb = new EmployeeDAO();
        }

        public IMongoCollection<BsonDocument> GetEmployees()
        {
            return employeedb.GetAllEmployees();
        }
    }
}