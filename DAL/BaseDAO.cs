using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
using System;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

namespace DAL
{
    public class BaseDAO
    {
        private readonly MongoClient client;

        public MongoClient Client { get => client; }

        const string ConfigFile = "config.json"; // Config file name that contains the connection string.

        protected IMongoDatabase Database { get; private set; }

        public BaseDAO()
        {
            client = new MongoClient(ReadConfig(ConfigFile));
            database = Client.GetDatabase("GardenGroup");
        }

        /// <summary>
        /// Returns the configuration file read from JSON file.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private string ReadConfig(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Config file does not exist.");
            }

            StreamReader reader = new StreamReader(filename);
            string content = reader.ReadToEnd();
            reader.Close();

            dynamic json = JsonConvert.DeserializeObject<dynamic>(content);
            return json.connectionString;
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
