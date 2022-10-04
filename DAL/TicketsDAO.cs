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


        public IMongoCollection<BsonDocument> Tickets
        {
            get { return tickets; }

            set { tickets = value; }
        }


        public TicketsDAO()
        {
            database = Client.GetDatabase("database name");
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
