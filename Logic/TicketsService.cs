using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace Logic
{
    public class TicketsService
    {
        public TicketsDAO ticketsdb;

        public TicketsService()
        {
            ticketsdb = new TicketsDAO();
        }

        private List<Ticket> ConvertToTicketList(IAsyncCursor<BsonDocument> cursor)
        {
            List<Ticket> ticketList = new List<Ticket>();
            foreach (var entry in cursor.ToEnumerable())
            {
                Ticket ticket = BsonSerializer.Deserialize<Ticket>(entry);
                ticketList.Add(ticket);
            }
            return ticketList;
        }

        public List<Ticket> GetTickets()
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

            var bsonOutput = ticketsdb.Get(pipeline);
            return ConvertToTicketList(bsonOutput);
        }

        public List<Ticket> GetTicketsByStatus(TicketStatus status)
        {
            try
            {
                // Create stages for the pipeline
                var lookUp = new BsonDocument("$lookup",
                    new BsonDocument
                    {
                    { "from", "Employees" },
                    { "localField", "reporter" },
                    { "foreignField", "_id" },
                    { "as", "reporterPerson" }
                    });
                var unwind = new BsonDocument("$unwind", new BsonDocument("path", "$reporterPerson"));
                var match = new BsonDocument("$match", new BsonDocument("status", (int)status));

                // Create pipeline
                var pipeline = new[] { lookUp, unwind, match };

                // Return tickets by status
                return ConvertToTicketList(ticketsdb.Get(pipeline));
            }
            catch (FormatException ex) // Dummy code... Adjust properly later
            {
                throw new FormatException("An error occured handling the format out of the database", ex);
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("Null exception", ex);
            }
        }

        public Ticket GetById(int ticketId)
        {
            var lookUp = new BsonDocument("$lookup",
                                        new BsonDocument
                                        {
                                            { "from", "Employees" },
                                            { "localField", "reporter" },
                                            { "foreignField", "_id" },
                                            { "as", "reporterPerson" }
                                        });
            var match = new BsonDocument("$match", new BsonDocument("_id", ticketId));
            var pipeline = new[] { lookUp, match };
            var tickets = ticketsdb.Get(pipeline).ToList();

            if (tickets.Count == 0)
            {
                return null;
            }

            return new Ticket();
        }

        // Dashboard methods
        public long GetTotalTicketCount()
        {
            try
            {
                // Get total ticket count
                return ticketsdb.GetTotalTicketCount();
            }
            catch (FormatException ex) // Dummy code... Adjust properly later
            {
                throw new FormatException("An error occured handling the format out of the database", ex);
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("Null exception", ex);
            }
        }

        public long GetTicketCountByType(TicketStatus status)
        {
            try
            {
                // Create a filter and return the count by ticket status
                var filter = new BsonDocument("status", (int)status);
                return ticketsdb.GetTicketCountByStatus(filter);
            }
            catch (FormatException ex) // Dummy code... Adjust properly later
            {
                throw new FormatException("An error occured handling the format out of the database", ex);
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("Null exception", ex);
            }
        }

        /// <summary>
        /// Inserts a new ticket into the database.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="subject"></param>
        /// <param name="type"></param>
        /// <param name="reporter"></param>
        /// <param name="priority"></param>
        /// <param name="followUpDays"></param>
        /// <param name="description"></param>
        public void InsertTicket(DateTime date, string subject, IncidentTypes type, Employee reporter, TicketPriority priority, int followUpDays, string description)
        {
            BsonDocument doc = new BsonDocument();
            doc.Add(new BsonElement("_id", GetHighestId() + 1));
            doc.Add(new BsonElement("type", (int)type));
            doc.Add(new BsonElement("subject", subject));
            doc.Add(new BsonElement("description", description));
            doc.Add(new BsonElement("reporter", reporter.Id));
            doc.Add(new BsonElement("date", date));
            doc.Add(new BsonElement("deadline", date.AddDays(followUpDays)));
            doc.Add(new BsonElement("priority", priority));
            doc.Add(new BsonElement("status", TicketStatus.Open));

            ticketsdb.Insert(doc);
        }

        /// <summary>
        /// Updates the provided ticket.
        /// </summary>
        /// <param name="ticket">Ticket to update.</param>
        public void UpdateTicket(Ticket ticket, string subject, string description, IncidentTypes type, TicketPriority priority, TicketStatus status, Employee employee)
        {
            ticket.Subject = subject;
            ticket.Description = description;
            ticket.IncidentType = type;
            ticket.Priority = priority;
            ticket.Status = status;
            ticket.Reporter = employee;

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.Id);
            var update = Builders<BsonDocument>.Update.Set("type", (int)ticket.IncidentType)
                                                    .Set("subject", ticket.Subject)
                                                    .Set("description", ticket.Description)
                                                    .Set("reporter", ticket.Reporter.Id)
                                                    .Set("priority", (int)ticket.Priority)
                                                    .Set("status", (int)ticket.Status);

            ticketsdb.Update(filter, update);
        }

        /// <summary>
        /// Remove the provided ticket from the database.
        /// </summary>
        /// <param name="ticket">Ticket to be removed</param>
        public void DeleteTicket(Ticket ticket)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.Id);
            ticketsdb.Remove(filter);
        }

        public int GetHighestId()
        {
            var project = new BsonDocument("$project",
                          new BsonDocument("_id", 1));
            var sort = new BsonDocument("$sort",
                       new BsonDocument("_id", -1));
            var limit = new BsonDocument("$limit", 1);

            var pipeline = new[] { project, sort, limit };

            var output = ticketsdb.Get(pipeline).ToList();
            if (output.Count > 0)
            {
                return (int)output.First().GetValue(0);
            }

            return 0;
        }
    }
}