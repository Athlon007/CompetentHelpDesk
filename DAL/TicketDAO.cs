using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class TicketDAO : DAO
    {
        private IMongoDatabase database;
        private IMongoCollection<BsonDocument> tickets;

        public IMongoCollection<BsonDocument> Tickets { get; set; }

        public TicketDAO()
        {
            database = Client.GetDatabase("Database name");
        }
        public IMongoCollection<BsonDocument> GetAllTickets()
        {
            Tickets = database.GetCollection<BsonDocument>("Tickets");
            return Tickets;
        }

        public BsonDocument GetById(string id)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("Id", id);
            var ticket = Tickets.Find(filter).FirstOrDefault();

            return ticket;
        }

        public long GetTotalTicketCount()
        {
            try
            {
                // Update collection in case of change?? Return count of document
                Tickets = GetAllTickets();
                return Tickets.CountDocuments(new BsonDocument());
            }
            catch // Throw exception, handle the exception in the service layer
            {
                throw;
            }
        }

        public long GetTicketCountByType(string status)
        {
            try
            {
                // Filter
                var filter = Builders<BsonDocument>.Filter.Eq("Status", status);

                // Update collection in case of change??
                Tickets = GetAllTickets();

                // Get count of documents of type in collection
                var tickets = Tickets.Find(filter);
                return tickets.CountDocuments();
            }
            catch // Throw exception, handle the exception in the service layer
            {
                throw;
            }
        }
    }
}
