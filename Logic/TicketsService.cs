using System;
using System.Collections.Generic;
using System.Linq;
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
            return ticketsdb.GetAllTickets().AsQueryable().ToList();
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

        public void InsertTicket(DateTime date, string subject, IncidentTypes type, Employee reporter, TicketPriority priority, int followUpDays, string description)
        {
            Ticket t = new Ticket();
            t.Date = date;
            t.Status = TicketStatus.Open;
            t.Subject = subject;
            t.IncidentType = type;
            t.Reporter = reporter;
            t.Priority = priority;
            t.Deadline = date.AddDays(followUpDays);
            t.Description = description;
            ticketsdb.InsertTicket(t);
        }

        public int GenerateNewTicketId()
        {
            return ticketsdb.GenerateNewTicketId();
        }
    }
}