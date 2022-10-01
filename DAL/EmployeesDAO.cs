using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;


namespace DAL
{
    public class EmployeesDAO :BaseDAO
    {
        private IMongoDatabase database;
        private IMongoCollection<BsonDocument> employees;

        public IMongoCollection<BsonDocument> Employees { get; set; }

        public EmployeesDAO()
        {
            database = Client.GetDatabase("Database name");
        }
        public IMongoCollection<BsonDocument> GetAllEmployees()
        {
            Employees = database.GetCollection<BsonDocument>("Employees");
            return Employees;
        }

        public BsonDocument GetById(string id)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("Id", id);
            var employee = Employees.Find(filter).FirstOrDefault();

            return employee;
        }


        //Using collection Employees
        //using the following script for data
        // db.Employees.insertOne({'Id': '1', 'Email': 'someone@outlook.com', 'Username': 'Employee1', 'FirstName': 'First name', 'LastName': 'Last name', 'PasswordHash': 'PasswordHash', 'Salt':'Salt'})

        //deserialize document to use instance of class in the UI
        public Employee ConvertDocumentToObject(BsonDocument bsonDocument)
        {
            Employee instance = BsonSerializer.Deserialize<Employee>(bsonDocument);

            return instance;

        }



        public List<Employee> ConvertAllDocumentsToEmployeesList(IMongoCollection<BsonDocument> employeedb) 
        {
            int dbdocuments = RetrieveDocumentsCount(employeedb);
            List<Employee> employees = new List<Employee>();
     
            for (int i= 1; i < dbdocuments+1;i++) 
            {
                var builder = Builders<BsonDocument>.Filter;
                var filter = builder.Gte("Id", i.ToString());
                var document = employeedb.Find(filter).FirstOrDefault();
                Employee employee = ConvertDocumentToObject((BsonDocument)document);
                employees.Add(employee);
            }
            return employees;
        
        }

    }
}
