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
    public class EmployeesService
    {

        private EmployeesDAO employeesdb;

        public EmployeesService()
        {
            employeesdb = new EmployeesDAO();
        }

        public IMongoCollection<BsonDocument> GetEmployees()
        {
            return employeesdb.GetAllEmployees();
        }

        public BsonDocument GetById(string employeeId)
        {
            BsonDocument employee = employeesdb.GetById(employeeId);
            return employee;
        }

        public BsonDocument GetByUsername(string userName)
        {
            BsonDocument employee = employeesdb.GetByUsername(userName);
            return employee;
        }

        public Employee ConvertDocumentToObject(BsonDocument bsonDocument) 
        { 
            return employeesdb.ConvertDocumentToObject(bsonDocument);    
        
        }


        public List<Employee> ConvertAllDocumentsToEmployeesList(IMongoCollection<BsonDocument> employeedb)
        {
            EmployeesDAO employeesDAO = new EmployeesDAO();
            List<Employee> employees = employeesDAO.ConvertAllDocumentsToEmployeesList(employeedb);

            return employees;

        }

    }
}