using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class EmployeesDAO :DAO
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
    }
}
