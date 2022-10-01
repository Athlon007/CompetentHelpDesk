using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Logic
{
    public class TicketService
    {
        IMongoCollection<BsonDocument> tickets;

        public TicketDAO ticketsdb;

        public TicketService()
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
        public int GetAllTicketsCount()
        {
            // For future reference:
            //string query = "db.incidents.countDocuments({})";
            //return ticketsdb.GetTicketsCount(query);

            //Test sample for now
            return 99;
        }

        public int GetOpenTicketsCount()
        {
            // For future reference:
            //string query = "db.incidents.countDocuments({'status' : 'open'})";
            //return ticketsdb.GetTicketsCount(query);

            // Test sample for now
            return 19;
        }

        public int GetPastDeadLineTicketsCount()
        {
            // For future reference:
            //string query = "db.incidents.countDocuments({'status' : 'pastdeadline'})";
            //return ticketsdb.GetTicketsCount(query);

            // Test sample for now
            return 3;
        }

        public int GetUnresolvedTicketsCount()
        {
            // For future reference:
            //string query = "db.incidents.countDocuments({'status' : 'unresolved'})";
            //return ticketsdb.GetTicketsCount(query);

            // Test sample for now
            return 7;
        }

        public int GetResolvedTicketsCount()
        {
            // For future reference:
            //string query = "db.incidents.countDocuments({'status' : 'resolved'})";
            //return ticketsdb.GetTicketsCount(query);

            // Test sample for now
            return 70;
        }
    }
}
