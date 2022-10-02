using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Logic
{
    public class TicketsService
    {
        IMongoCollection<BsonDocument> tickets;

        public TicketsDAO ticketsdb;

        public TicketsService()
        {
            //ticketsdb = new TicketsDAO();
        }

        public IMongoCollection<BsonDocument> GetTickets()
        {
            return ticketsdb.GetAllTickets();
        }

        public BsonDocument GetById(string ticketId)
        {
            BsonDocument ticket = ticketsdb.GetById(ticketId);
            return ticket;
        }

        // Dashboard methods
        public long GetTotalTicketCount()
        {
            return 30; // Dummy data

            try
            {
                // Get total ticket count
                return ticketsdb.GetTotalTicketCount();
            }
            catch (FormatException ex) // Dummy code... Adjust properly later
            {
                throw new FormatException("An error occured handling the format out of the database", ex);
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("Null exception", ex);
            }
        }

        public long GetTicketCountByType(TicketStatus status)
        {
            return 19; // Dummy data...

            // Get filter by type
            string filter = GetTicketCountByTypeFilter(status);

            try
            {
                return ticketsdb.GetTicketCountByType(filter);
            }
            catch (FormatException ex) // Dummy code... Adjust properly later
            {
                throw new FormatException("An error occured handling the format out of the database", ex);
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("Null exception", ex);
            }
        }

        private string GetTicketCountByTypeFilter(TicketStatus status)
        {
            // Get filter word with appropiate enum
            switch (status)
            {
                case TicketStatus.PastDeadline:
                    return "pastdeadline";
                case TicketStatus.Unresolved:
                    return "unresolved";
                case TicketStatus.Resolved:
                    return "resolved";
                default:
                    return "open";
            }

            public Ticket ConvertDocumentToObject(BsonDocument bsonDocument)
            {
                return ticketsdb.ConvertDocumentToObject(bsonDocument);

            }


            public List<Ticket> ConvertAllDocumentsToTicketsList(IMongoCollection<BsonDocument> ticketsdb)
            {
                TicketsDAO ticketsDAO = new TicketsDAO();
                List<Ticket> tickets = ticketsDAO.ConvertAllDocumentsToTicketsList(ticketsdb);

                return tickets;

            }
        }
    }
}