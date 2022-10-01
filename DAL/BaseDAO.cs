using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using System;
using System.Linq;

namespace DAL
{
    public class BaseDAO
    {
        private readonly MongoClient client;

        public MongoClient Client { get { return client; } }    

        public BaseDAO()
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



        public int RetrieveDocumentsCount(IMongoCollection<BsonDocument> db)
        {
            List<BsonDocument> documentsList = db.Find(new BsonDocument()).ToList();
            int count = documentsList.Count();
            return count;

        }


    }
}
