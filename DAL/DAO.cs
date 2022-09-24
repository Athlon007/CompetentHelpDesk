using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using System;

namespace DAL
{
    public class DAO
    {
        private readonly MongoClient client;

        public MongoClient Client { get { return client; } }    

        public DAO()
        {
            client = new MongoClient("connection string");
        }

        public List<Databases_Model> GetDatabases()
        {
            //list with existing databases 
            List<Databases_Model> all_databases = new List<Databases_Model>();


            //create a document
            
            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                //convert string for db to object with fields from the db model
                //then add to list (deserialized into database model)
                all_databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
            }
            return all_databases;

        }




        public void Test(List<Databases_Model> dbs)
        {
            var dbList = client.ListDatabases().ToList();
            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbs)
            {
                Console.WriteLine($"Database: {db.name}");
                Console.WriteLine($"Size: {db.size}");
                Console.WriteLine($"IsEmpty: {db.empty}");
                Console.WriteLine();
            }
        }
    }
}
