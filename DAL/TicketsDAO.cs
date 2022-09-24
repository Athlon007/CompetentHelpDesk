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
    public class TicketsDAO: DAO
    {
        private IMongoDatabase database;
        private IMongoCollection<BsonDocument> tickets;

        public IMongoCollection<BsonDocument> Tickets { get; set; }

        public TicketsDAO()
        {
            database = Client.GetDatabase("Database name");
        }
        public IMongoCollection<BsonDocument> GetAllTickets()
        {
            Tickets = database.GetCollection<BsonDocument>("Tickets");
            return Tickets;
        }
    }
}
