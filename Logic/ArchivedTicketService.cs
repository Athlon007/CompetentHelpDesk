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
    public class ArchivedTicketService
    {
        private ArchivedTicketDAO archivedTicketDb;
        private TicketsDAO ticketdb = new TicketsDAO();
        private IMongoCollection<BsonDocument> tickets;


        public ArchivedTicketService()
        {
            archivedTicketDb = new ArchivedTicketDAO();
        }

        public List<BsonDocument> GetAllTicketsToCheckArchivingDate()
        {
            return archivedTicketDb.GetAllTicketsToCheckArchivingDate();
        }


        public List<BsonDocument> GetAllArchivedTickets()
        {
            return archivedTicketDb.GetAllArchivedTickets();
        }

        public Ticket ConvertDocumentToTicketInstanceForArchiving(BsonDocument bsonDocument)
        {
            return archivedTicketDb.ConvertDocumentToTicketInstanceForArchiving(bsonDocument);
        }

        public ArchivedTicket ConvertDocumentToArchivedTicketInstance(BsonDocument bsonDocument)
        {
            return archivedTicketDb.ConvertDocumentToArchivedTicketInstance(bsonDocument);
        }


        public List<ArchivedTicket> ConvertAllDocumentsToArchivedTicketList(List<BsonDocument> archivedTicketsDb)
        {
            return archivedTicketDb.ConvertAllDocumentsToArchivedTicketList(archivedTicketsDb);
        }

        public BsonDocument CreateDocumentFromArchivedTicketInstance(ArchivedTicket archivedTicket)
        {
            return archivedTicketDb.CreateDocumentFromArchivedTicketInstance(archivedTicket);
        }

        public void CreateArchivedTicket(BsonDocument document)
        {
            archivedTicketDb.CreateArchivedTicket(document);
        }


        public void RemoveArchivedTicketFromTicketDb(int id)
        {
            archivedTicketDb.RemoveArchivedTicketFromTicketDb(id);
        }

        public void ArchiveTickets()
        {
            DateTime currentDate = DateTime.Now;

            List<BsonDocument>tickets = GetAllTicketsToCheckArchivingDate();
            int archivedTicketId = archivedTicketDb.RetrievePreviousDocumentId();   

            foreach (BsonDocument document in tickets)
            {
                Ticket ticket = ConvertDocumentToTicketInstanceForArchiving((BsonDocument)document);
               

                if ((currentDate - ticket.Date).TotalDays >= 14)
                { 
                    ArchivedTicket archivedTicket = new ArchivedTicket();
                    archivedTicket.Id = archivedTicketId++;
                    archivedTicket.IncidentType = ticket.IncidentType;
                    archivedTicket.Subject = ticket.Subject;
                    archivedTicket.Description = ticket.Description;
                    archivedTicket.TicketId = ticket.Id;
                    archivedTicket.Date = ticket.Date;
                    archivedTicket.Deadline = ticket.Deadline;
                    archivedTicket.Priority = ticket.Priority;
                    archivedTicket.Status = ticket.Status;
                    archivedTicket.EscalationLevel = ticket.EscalationLevel;
                    archivedTicket.IsClosed = ticket.IsClosed;
                    archivedTicket.ArchivingDate = currentDate;

                    BsonDocument archivedTicketDocument = CreateDocumentFromArchivedTicketInstance(archivedTicket);
                    CreateArchivedTicket(archivedTicketDocument);
                    RemoveArchivedTicketFromTicketDb(ticket.Id);

                }
            }
        }
    }
}
