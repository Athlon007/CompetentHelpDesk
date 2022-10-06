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
        public IEnumerable<Ticket> All(BsonDocument[] pipeline)
        {
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
        /// Inserts a new ticket into the database.
        /// </summary>
        public void Insert(BsonDocument doc)
        {
           

            Database.GetCollection<BsonDocument>(CollectionName).InsertOne(doc);
        }

        /// <summary>
        /// Generates new ticket ID, based on the highest ticket ID value + 1.
        /// </summary>
        public int GetHighestId()
        {
            var project = new BsonDocument("$project",
                          new BsonDocument("_id", 1));
            var sort = new BsonDocument("$sort",
                       new BsonDocument("_id", -1));
            var limit = new BsonDocument("$limit", 1);

            var pipeline = new[] {project, sort, limit};

            var output = Database.GetCollection<BsonDocument>(CollectionName).Aggregate<BsonDocument>(pipeline).ToEnumerable();         

            return (int)output.First().GetValue(0);
        }

        /// <summary>
        /// Updates currently existing ticket in the database.
        /// </summary>
        /// <param name="ticket"></param>
        public void Update(FilterDefinition<BsonDocument> filter, UpdateDefinition<BsonDocument> update)        
        {
            Database.GetCollection<BsonDocument>(CollectionName).UpdateOne(filter, update);
        }

        /// <summary>
        /// Removes a document
        /// </summary>
        public void Remove(FilterDefinition<BsonDocument> filter)
        {
            //var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.Id);
            Database.GetCollection<BsonDocument>(CollectionName).DeleteOne(filter);
        }
    }
}
