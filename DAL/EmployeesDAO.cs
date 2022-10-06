using System.Collections.Generic;
using System.Linq;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using System.Collections;


namespace DAL
{
    public class EmployeesDAO :BaseDAO
    {
        public IAsyncCursor<BsonDocument> Get(BsonDocument[] pipeline)
        {
            return Database.GetCollection<Ticket>("Employees").Aggregate<BsonDocument>(pipeline);
        }

        public IAsyncCursor<BsonDocument> Get()
        {
            return Get(new BsonDocument[] { });
        }

        public Employee GetById(int id)
        {
            var builder = Builders<Employee>.Filter;
            var filter = builder.Eq("_id", id);
            var employee = Database.GetCollection<Employee>("Employees").Find(filter).FirstOrDefault();

            return employee;
        }

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
