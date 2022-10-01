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

        public Employee ConvertDocumentToObject(BsonDocument bsonDocument) 
        { 
            return employeedb.ConvertDocumentToObject(bsonDocument);    
        
        }


        public List<Employee> ConvertAllDocumentsToEmployeesList(IMongoCollection<BsonDocument> employeedb)
        {
            EmployeesDAO employeesDAO = new EmployeesDAO();
            List<Employee> employees = employeesDAO.ConvertAllDocumentsToEmployeesList(employeedb);

            return employees;

        }

    }
}