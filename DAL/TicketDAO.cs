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
    public class TicketDAO: DAO
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

        public int GetTicketCount(string query)
        {
            // Filler data
            return 1;
        }
    }
}
