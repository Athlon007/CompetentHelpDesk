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
    public class TicketsService
    {
        IMongoCollection<BsonDocument> tickets;

        public TicketsDAO ticketsdb;

        public TicketsService()
        {
            ticketsdb = new TicketsDAO();
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

  

    }
}
