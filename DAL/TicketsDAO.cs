using System.Collections.Generic;
using System.Linq;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;


namespace DAL
{
    public class TicketsDAO: BaseDAO
    {
        public IMongoCollection<BsonDocument> Tickets { get; set; }

        /// <summary>
        /// Returns all tickets.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Ticket> GetAllTickets()
        {
            var collection = Database.GetCollection<Ticket>("Tickets");

            var lookup = new BsonDocument("$lookup",
                        new BsonDocument
                            {
                                { "from", "Employees" },
                                { "localField", "reporter" },
                                { "foreignField", "_id" },
                                { "as", "reporter" }
                            });
            var unwind = new BsonDocument("$unwind", new BsonDocument("path", "$reporter"));

            var pipeline = new[] { lookup, unwind };

            return collection.Aggregate<Ticket>(pipeline).ToEnumerable();
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
                //return GetAllTickets().CountDocuments(new BsonDocument());
                return GetAllTickets().Count();
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
                var filter = Builders<Ticket>.Filter.Eq("Status", status);

                // Get count of documents of type in collection
                //var tickets = GetAllTickets().Find(filter);
                //return tickets.CountDocuments();
                return 0;
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
