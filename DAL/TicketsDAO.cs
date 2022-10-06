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
        private const string CollectionName = "Tickets";

        /// <summary>
        /// Returns all tickets.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Ticket> GetAllTickets()
        {
            var lookUp = new BsonDocument("$lookup",
                                        new BsonDocument
                                            {
                                                { "from", "Employees" },
                                                { "localField", "reporter" },
                                                { "foreignField", "_id" },
                                                { "as", "reporterPerson" }
                                            });
            var unwind = new BsonDocument("$unwind", new BsonDocument("path", "$reporterPerson"));

            var pipeline = new[] { lookUp, unwind };

            return Database.GetCollection<Ticket>(CollectionName).Aggregate<Ticket>(pipeline).ToEnumerable();
        }

        public IEnumerable<Ticket> GetTicketsByStatus(BsonDocument[] pipeline)
        {
            try
            {
                return Database.GetCollection<Ticket>(CollectionName).Aggregate<Ticket>(pipeline).ToEnumerable();
            }
            catch // Throw exception, handle the exception in the service layer
            {
                throw;
            }
        }

        /// <summary>
        /// Returns ticket by its ID.
        /// </summary>
        /// <param name="id">ID to lookup</param>
        public Ticket GetById(int id)
        {
            var builder = Builders<Ticket>.Filter;
            var filter = builder.Eq("_id", id);
            var ticket = Database.GetCollection<Ticket>(CollectionName).Find(filter).FirstOrDefault();

            return ticket;
        }



        public long GetTotalTicketCount()
        {
            try
            {
                // Return count of documents in collection
                return Database.GetCollection<Ticket>(CollectionName).CountDocuments(new BsonDocument());
            }
            catch // Throw exception, handle the exception in the service layer
            {
                throw;
            }
        }

        public long GetTicketCountByStatus(BsonDocument filter, TicketStatus status)
        {
            try
            {
                // Return count of documents in collection by ticket status
                return Database.GetCollection<Ticket>(CollectionName).Find(filter).CountDocuments();
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

        /// <summary>
        /// Inserts a new3 ticket into the database.
        /// </summary>
        /// <param name="ticket">New ticket object to insert (ID will be generated in this void).</param>
        public void InsertTicket(Ticket ticket)
        {
            ticket.Id = GenerateNewTicketId();

            BsonDocument doc = new BsonDocument();
            doc.Add(new BsonElement("_id", ticket.Id));
            doc.Add(new BsonElement("type", (int)ticket.IncidentType));
            doc.Add(new BsonElement("subject", ticket.Subject));
            doc.Add(new BsonElement("description", ticket.Description));
            doc.Add(new BsonElement("reporter", ticket.Reporter.Id));
            doc.Add(new BsonElement("date", ticket.Date));
            doc.Add(new BsonElement("deadline", ticket.Deadline));
            doc.Add(new BsonElement("priority", (int)ticket.Priority));
            doc.Add(new BsonElement("status", (int)ticket.Status));

            Database.GetCollection<BsonDocument>(CollectionName).InsertOne(doc);
        }

        /// <summary>
        /// Generates new ticket ID, based on the highest ticket ID value + 1.
        /// </summary>
        private int GenerateNewTicketId()
        {
            var project = new BsonDocument("$project",
                          new BsonDocument("_id", 1));
            var sort = new BsonDocument("$sort",
                       new BsonDocument("_id", -1));
            var limit = new BsonDocument("$limit", 1);

            var pipeline = new[] {project, sort, limit};

            var output = Database.GetCollection<BsonDocument>(CollectionName).Aggregate<BsonDocument>(pipeline).ToEnumerable();         

            return (int)output.First().GetValue(0) + 1;
        }
    }
}
