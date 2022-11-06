using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Bson;
using Model;

namespace DAL
{
    public class IncidentDAO: BaseDAO
    {

        private IMongoDatabase database;
        private IMongoCollection<BsonDocument> incidents;



        public IMongoCollection<BsonDocument> Incidents
        {
            get { return incidents; }

            set { incidents = value; }
        }


        public IncidentDAO()
        {
            database = Client.GetDatabase("GardenGroup");
        }
        public IMongoCollection<BsonDocument> GetAllIncidents()
        {
            incidents = database.GetCollection<BsonDocument>("Incidents");
            return Incidents;
        }




        //Using collection Incidents
        //deserialize document to use instance of class in the UI
        public Incident ConvertDocumentToObject(BsonDocument bsonDocument)
        {
            Incident instance = BsonSerializer.Deserialize<Incident>(bsonDocument);

            return instance;

        }


        public int RetrieveDocumentsCount(IMongoCollection<BsonDocument> db)
        {
            List<BsonDocument> documentsList = db.Find(new BsonDocument()).ToList();
            int count = documentsList.Count();
            return count;

        }


        public List<Incident> ConvertAllDocumentsToIncidentList(IMongoCollection<BsonDocument> incidentsdb)
        {
            int dbdocuments = RetrieveDocumentsCount(incidentsdb);
            List<Incident> incidentsList = new List<Incident>();

            for (int i = 0; i < dbdocuments; i++)
            {
                var builder = Builders<BsonDocument>.Filter;
                var filter = builder.Gte("Id", i);
                var document = incidentsdb.Find(filter).FirstOrDefault();
                Incident incident = ConvertDocumentToObject((BsonDocument)document);
                incidentsList.Add(incident);
            }
            return incidentsList;

        }


        public void CreateIncident(BsonDocument document)
        {
            Database.GetCollection<BsonDocument>("Incidents").InsertOne(document);

        }

      

    }
}
