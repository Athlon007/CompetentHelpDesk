using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class IncidentDAO: BaseDAO
    {

        private List<BsonDocument> incidents;
        private IMongoCollection<BsonDocument> incidentDatabase;


        public List<BsonDocument> GetAllIncidents()
        {
            incidents = Database.GetCollection<BsonDocument>("Incidents").Find(new BsonDocument()).ToList();
            return incidents;
        }

        //Using collection Incidents
        //deserialize document to use instance of class in the UI
        public Incident ConvertDocumentToIncidentInstance(BsonDocument bsonDocument)
        {
            Incident instance = BsonSerializer.Deserialize<Incident>(bsonDocument);

            return instance;

        }


        public List<Incident> ConvertAllDocumentsToIncidentList(List<BsonDocument> incidentsDb)
        {

            int dbdocuments = incidentsDb.Count;
            List<Incident> incidentList = new List<Incident>();
            if (dbdocuments > 0)
            {
                foreach (BsonDocument document in incidentsDb)
                {
                   Incident incident = ConvertDocumentToIncidentInstance((BsonDocument)document);
                   incidentList.Add(incident);
                }
            }
            return incidentList;
        }


        public int RetrievePreviousDocumentId()
        {
            List<BsonDocument> incidents = GetAllIncidents();
            List<Incident> incidentList = ConvertAllDocumentsToIncidentList(incidents);
            int documentsCount = incidentList.Count;
            int incidentId;
            if (documentsCount == 0)
            { incidentId = 0; }
            else
            {
                int previousIncidentId = incidentList[incidentList.Count - 1].Id;

                incidentId = ++previousIncidentId;
            }

            return incidentId;
        }


        public void CreateIncident(BsonDocument document)
        {
            Database.GetCollection<BsonDocument>("Incidents").InsertOne(document);
        }


        public void RemoveIncidentFromIncidentDb(int id)
        {
            incidentDatabase = Database.GetCollection<BsonDocument>("Incidents");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("Id", id);
            var document = incidentDatabase.Find(filter).FirstOrDefault();

            Database.GetCollection<BsonDocument>("Incidents").DeleteOne(document);
        }

    }
}
