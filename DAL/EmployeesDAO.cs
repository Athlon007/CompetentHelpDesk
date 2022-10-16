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

        public Employee GetByUsername(string username)
        {
            var builder = Builders<Employee>.Filter;
            var filter = builder.Eq("username", username);
            var employee = Database.GetCollection<Employee>("Employees").Find(filter).FirstOrDefault();

            return employee;
        }

    


        //deserialize document to use instance of class in the UI
        public Employee ConvertDocumentToObject(BsonDocument bsonDocument)
        {
            Employee instance = BsonSerializer.Deserialize<Employee>(bsonDocument);
            return instance;
        }

       


    }
}
