using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using DAL;
using Model;
using MongoDB.Bson;
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

            return ticketsdb.All(pipeline).AsQueryable().ToList();
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
                return ticketsdb.GetTicketsByStatus(pipeline).AsQueryable().ToList();
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
            return ticketsdb.GetById(ticketId);
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
                return ticketsdb.GetTicketCountByStatus(filter, status);
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
            Ticket t = new Ticket();
            t.Id = ticketsdb.GetHighestId() + 1;
            t.Date = date;
            t.Status = TicketStatus.Open;
            t.Subject = subject;
            t.IncidentType = type;
            t.Reporter = reporter;
            t.Priority = priority;
            t.Deadline = date.AddDays(followUpDays);
            t.Description = description;

            BsonDocument doc = new BsonDocument();
            doc.Add(new BsonElement("_id", ticketsdb.GetHighestId() + 1));
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
    }
}