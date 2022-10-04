using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using System;
using System.Linq;
using System.IO;

namespace DAL
{
    public class BaseDAO
    {
        private readonly MongoClient client;
        public MongoClient Client { get => client; }     
        protected IMongoDatabase Database { get; private set; }

        private ConfigFile config;

        public BaseDAO()
        {
            config = new ConfigFile();
            client = new MongoClient(config.ConnectionString);
            Database = client.GetDatabase(config.DatabaseName);
        }

        public BaseDAO(string configString, string databaseName)
        {
            client = new MongoClient(configString);
            Database = client.GetDatabase(databaseName);
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
