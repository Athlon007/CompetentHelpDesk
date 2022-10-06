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

        /// <summary>
        /// Returns a premade pipeline.
        /// </summary>
        /// <returns></returns>
        private List<BsonDocument> GetTicketPipeline()
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

            return new List<BsonDocument>(){ lookUp, unwind };
        }

        /// <summary>
        /// Converts BsonDocuments enumerable to list of tickets.
        /// </summary>
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

        /// <summary>
        /// Returns the list of all tickets in the system.
        /// </summary>
        /// <param name="output">List object to which the output will be returned.</param>
        /// <returns>A status code and status message.</returns>
        public StatusStruct GetTickets(out List<Ticket> output)
        {
            try
            {
                var bsonOutput = ticketsdb.Get(GetTicketPipeline());
                output = ConvertToTicketList(bsonOutput);
                return new StatusStruct(0);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                output = new List<Ticket>();
                return new StatusStruct(1, "Unable to access tickets. Try again later.");
            }
        }

        public List<Ticket> GetTicketsByStatus(TicketStatus status)
        {
            try
            {
                // Create stages for the pipeline
                var pipeline = GetTicketPipeline();
                pipeline.Add(new BsonDocument("$match", new BsonDocument("status", (int)status)));

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

        /// <summary>
        /// Returns the ticket by its ID.
        /// </summary>
        /// <param name="ticketId">Ticket ID to look for.</param>
        public StatusStruct GetById(int ticketId, out Ticket output)
        {
            try
            {
                var pipeline = GetTicketPipeline();
                pipeline.Add(new BsonDocument("$match", new BsonDocument("_id", ticketId)));
                var tickets = ConvertToTicketList(ticketsdb.Get(pipeline));

                if (tickets.Count > 0)
                {
                    output = tickets.First();
                    return new StatusStruct(0);
                }
                output = null;
                return new StatusStruct(2, "Unable to find ticket with id " + ticketId);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                output = null;
                return new StatusStruct(1, "Could not retrieve data from the database. Try again later.");
            }
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
        /// <param name="date">Date of ticket submission.</param>
        /// <param name="subject">Subject of the ticket.</param>
        /// <param name="type">Incident Type</param>
        /// <param name="reporter"></param>
        /// <param name="priority"></param>
        /// <param name="followUpDays"></param>
        /// <param name="description"></param>
        /// <returns>Returns if sent successfully, and/or issues with the submission..</returns>
        public StatusStruct InsertTicket(DateTime date, string subject, IncidentTypes type, Employee reporter, TicketPriority priority, int followUpDays, string description)
        {
            string issues = "";
            if (!IsTicketSubmissionValid(ref issues, date, subject, type, reporter, priority, followUpDays, description))
            {
                return new StatusStruct(1, issues);
            }

            try
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
                return new StatusStruct(0, "");
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                return new StatusStruct(1, "Couldn't send data to the server. Try again later.");
            }
        }

        /// <summary>
        /// Updates the provided ticket.
        /// </summary>
        /// <param name="ticket">Ticket to update.</param>
        public StatusStruct UpdateTicket(Ticket ticket, string subject, string description, IncidentTypes type, TicketPriority priority, TicketStatus status, Employee employee)
        {
            string issues = "";
            if (string.IsNullOrEmpty(subject))
            {
                issues += "Subject is empty\n";
            }
            if (string.IsNullOrEmpty(description))
            {
                issues += "Description is empty\n";
            }

            // Subject or description empty? Return status as 1.
            if (issues.Length > 0)
            {
                return new StatusStruct(1, issues);
            }

            try
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
                return new StatusStruct(0);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                return new StatusStruct(1, "Unable to update the ticket. Try again later.");
            }
        }

        /// <summary>
        /// Remove the provided ticket from the database.
        /// </summary>
        /// <param name="ticket">Ticket to be removed</param>
        public StatusStruct DeleteTicket(Ticket ticket)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.Id);
                ticketsdb.Remove(filter);
                return new StatusStruct(0);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                return new StatusStruct(1, "Unable to delete a ticket. Try again later.");
            }
        }

        /// <summary>
        /// Returns the highest ticket ID in the database.
        /// </summary>
        private int GetHighestId()
        {
            try
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
            }
            catch (Exception ex) { ErrorHandler.Instance.WriteError(ex); }

            return 0;
        }

        /// <summary>
        /// Checks if ticket submission is valid.
        /// </summary>
        private bool IsTicketSubmissionValid(ref string reason, DateTime date, string subject, IncidentTypes type, Employee employee, TicketPriority priority, int deadline, string description)
        {
            if (date > DateTime.Now)
            {
                reason += "Incident time cannot be in the future\n";
            }

            if (string.IsNullOrEmpty(subject))
            {
                reason += "Subject is missing\n";
            }

            if ((int)type == -1)
            {
                reason += "Type of incident is not provided\n";
            }

            if (employee == null)
            {
                reason += "Reporting user not provided\n";
            }

            if ((int)priority == -1)
            {
                reason += "Priority not provided\n";
            }

            if (deadline == -1)
            {
                reason += "Deadline not provided\n";
            }

            if (string.IsNullOrEmpty(description))
            {
                reason += "Description not provided\n";
            }

            return reason.Length == 0;
        }
    }
}