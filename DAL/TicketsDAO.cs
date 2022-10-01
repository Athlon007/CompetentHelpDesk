using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;


namespace DAL
{
    public class TicketsDAO: BaseDAO
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

        public BsonDocument GetById(string id)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("Id", id);
            var ticket = Tickets.Find(filter).FirstOrDefault();

            return ticket;
        }


        //Using collection Tickets
        //using the following script for data
        //db.Tickets.insertOne({'Id':'1', 'Subject': 'Subject', 'UserId': '1', 'Date':'24/09/2022', 'Status': 'Status'})

        //deserialize document to use instance of class in the UI
        public Ticket ConvertDocumentToObject(BsonDocument bsonDocument)
        {
            Ticket instance = BsonSerializer.Deserialize<Ticket>(bsonDocument);

            return instance;

        }


        public List<Ticket> ConvertAllDocumentsToTicketsList(IMongoCollection<BsonDocument> ticketsdb)
        {
            int dbdocuments = RetrieveDocumentsCount(ticketsdb);
            List<Ticket> tickets = new List<Ticket>();

            for (int i = 1; i < dbdocuments + 1; i++)
            {
                var builder = Builders<BsonDocument>.Filter;
                var filter = builder.Gte("Id", i.ToString());
                var document = ticketsdb.Find(filter).FirstOrDefault();
                Ticket ticket = ConvertDocumentToObject((BsonDocument)document);
                tickets.Add(ticket);
            }
            return tickets;

        }

    }
}
