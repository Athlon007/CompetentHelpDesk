using DAL;
using Model;
using MongoDB.Bson;
using System.Collections.Generic;

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

        public List<BsonDocument> GetAllIncidents() 
        {
            return incidentdb.GetAllIncidents();    
        }

        public Incident ConvertDocumentToIncidentInstance(BsonDocument bsonDocument) { 

            return incidentdb.ConvertDocumentToIncidentInstance(bsonDocument);
        }


        public List<Incident> ConvertAllDocumentsToIncidentList(List<BsonDocument> incidentsdb)
        {
            return incidentdb.ConvertAllDocumentsToIncidentList(incidentsdb);
        }

        public int RetrievePreviousIncidentId() 
        { return incidentdb.RetrievePreviousDocumentId(); }


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


        public void RemoveIncidentFromIncidentDb(int id) 
        {
            incidentdb.RemoveIncidentFromIncidentDb(id);
        
        }
    }
}
