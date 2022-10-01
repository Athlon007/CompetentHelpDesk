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

        public List<DatabasesModel> GetDatabases()
        {
            //list with existing databases 
            List<DatabasesModel> allDatabases = new List<DatabasesModel>();


            //create a document
            
            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                //convert string for db to object with fields from the db model
                //then add to list (deserialized into database model)
                allDatabases.Add(BsonSerializer.Deserialize<DatabasesModel>(db));
            }
            return allDatabases;

        }



        public int RetrieveDocumentsCount(IMongoCollection<BsonDocument> db)
        {
            List<BsonDocument> documentsList = db.Find(new BsonDocument()).ToList();
            int count = documentsList.Count();
            return count;

        }


    }
}
