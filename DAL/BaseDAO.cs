using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using System.Linq;

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

        public IMongoDatabase GetDatabase()
        { return Database; }

        public List<DatabasesModel> GetDatabases()
        {
            //list with existing databases 
            List<DatabasesModel> allDatabases = new List<DatabasesModel>();


            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                //convert string for db to object with fields from the db model
                //then add to list (deserialized into database model)
                allDatabases.Add(BsonSerializer.Deserialize<DatabasesModel>(db));
            }
            return allDatabases;

        }

    }
}
