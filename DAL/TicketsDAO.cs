using System.Collections.Generic;
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
        /// <param name="pipeline">Pipeline to use.</param>
        public IAsyncCursor<BsonDocument> Get(BsonDocument[] pipeline)
        {
            return Database.GetCollection<BsonDocument>(CollectionName).Aggregate<BsonDocument>(pipeline);
        }

        /// <summary>
        /// Returns all BsonDocuments.
        /// </summary>
        /// <param name="pipeline">Pipeline to use.</param>
        public IAsyncCursor<BsonDocument> Get(List<BsonDocument> pipeline) 
        {
            return Get(pipeline.ToArray());
        }

        /// <summary>
        /// Returns amount of total tickets that are not escalated.
        /// </summary>
        public long GetTotalTicketCount(FilterDefinition<Ticket> filter)
        {
            try
            {
                // Return count of documents in collection (Non escalated)
                return Database.GetCollection<Ticket>(CollectionName).Find(filter).CountDocuments();
            }
            catch // Throw exception, handle the exception in the service layer
            {
                throw;
            }
        }

        /// <summary>
        /// Returns amount of tickets by status that are not escalated.
        /// </summary>
        public long GetTicketCountByStatus(FilterDefinition<Ticket> filter)
        {
            try
            {
                // Return count of documents in collection by ticket status (Non escalated)
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
