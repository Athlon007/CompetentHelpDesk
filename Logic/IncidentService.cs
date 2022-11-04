using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Bson;
using Model;
using DAL;

namespace Logic
{
    public  class IncidentService
    {
        private IncidentDAO incidentdb;


        public IncidentService()
        {
            incidentdb = new IncidentDAO();
        }

        public IMongoCollection<BsonDocument> GetAllIncidents() 
        {
            return incidentdb.GetAllIncidents();    
        }

        public Incident ConvertDocumentToObject(BsonDocument bsonDocument) { 

            return incidentdb.ConvertDocumentToObject(bsonDocument);
        }

        public int RetrieveDocumentsCount(IMongoCollection<BsonDocument> db)
        {
            return incidentdb.RetrieveDocumentsCount(db);
        }

        public List<Incident> ConvertAllDocumentsToIncidentList(IMongoCollection<BsonDocument> incidentsdb)
        {
            return incidentdb.ConvertAllDocumentsToIncidentList(incidentsdb);
        }

        public void CreateIncident(BsonDocument document) 
        {
            incidentdb.CreateIncident(document);
        
        }

    }
}
