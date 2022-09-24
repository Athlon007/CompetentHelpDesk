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
    public class EmployeeDAO :DAO
    {
        private IMongoDatabase database;
        private IMongoCollection<BsonDocument> employees;

        public IMongoCollection<BsonDocument> Employees { get; set; }

        public EmployeeDAO()
        {
            database = Client.GetDatabase("Database name");
        }
        public IMongoCollection<BsonDocument> GetAllEmployees()
        {
            Employees = database.GetCollection<BsonDocument>("Employees");
            return Employees;
        }
    }
}
