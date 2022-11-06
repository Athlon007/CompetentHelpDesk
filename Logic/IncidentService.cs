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
        private TicketsDAO ticketdb = new TicketsDAO();


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

        public void CreateIncident(Incident incident) 
        {
            BsonDocument document = new BsonDocument {
                { "Id", incident.Id }, 
                { "Subject", incident.Subject }, 
                { "UserId", incident.UserId }, 
                { "IncidentType", incident.IncidentType }, 
                { "LoggedOn", incident.LoggedOn },
                { "Description", incident.Description } };

            incidentdb.CreateIncident(document);
        
        }

        public void CreateTicketFromIncident(Ticket ticket)
        {
                BsonDocument document = new BsonDocument {
                { "_id", ticket.Id },
                { "type", (int)ticket.IncidentType },
                {"subject", ticket.Subject },
                { "description", ticket.Description },
                {"reporter", ticket.Reporter.Id},
                { "date", ticket.Date },
                { "deadline", ticket.Deadline },
                {"priority", (int)ticket.Priority },
                {"status", (int)ticket.Status },
                {"escalationLevel", ticket.EscalationLevel},
                {"IsClosed", ticket.IsClosed}
            };
            ticketdb.Insert(document);

        }
    }
}
