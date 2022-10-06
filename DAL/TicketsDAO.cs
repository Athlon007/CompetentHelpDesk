using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class TicketsDAO: BaseDAO
    {
        private const string CollectionName = "Tickets";

        /// <summary>
        /// Returns all BsonDocuments.
        /// </summary>
        /// <returns></returns>
        public IAsyncCursor<BsonDocument> Get(BsonDocument[] pipeline)
        {
            return Database.GetCollection<Ticket>(CollectionName).Aggregate<BsonDocument>(pipeline);
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

        public long GetTicketCountByStatus(BsonDocument filter)
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

        /// <summary>
        /// Inserts a new ticket into the database.
        /// </summary>
        public void Insert(BsonDocument doc)
        {
            Database.GetCollection<BsonDocument>(CollectionName).InsertOne(doc);
        }

        /// <summary>
        /// Update the document.
        /// </summary>
        public void Update(FilterDefinition<BsonDocument> filter, UpdateDefinition<BsonDocument> update)        
        {
            Database.GetCollection<BsonDocument>(CollectionName).UpdateOne(filter, update);
        }

        /// <summary>
        /// Removes a document
        /// </summary>
        public void Remove(FilterDefinition<BsonDocument> filter)
        {            
            Database.GetCollection<BsonDocument>(CollectionName).DeleteOne(filter);
        }
    }
}
