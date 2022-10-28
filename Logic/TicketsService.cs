using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace Logic
{
    public class TicketsService
    {
        protected TicketsDAO ticketsdb;

        public TicketsService()
        {
            ticketsdb = new TicketsDAO();
        }

        /// <summary>
        /// Returns a premade pipeline.
        /// </summary>
        private List<BsonDocument> GetTicketPipeline(Employee employee)
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
            BsonDocument matchForEmployeeLevel;
            if (employee.Type == EmployeeType.ServiceDesk)
            {
                // Service desk employees can see tickets that have escalation level 0, or not have it at all.
                matchForEmployeeLevel = new BsonDocument("$match",
                                            new BsonDocument("$or",
                                            new BsonArray
                                            {
                                                new BsonDocument("escalationLevel", BsonNull.Value),
                                                new BsonDocument("escalationLevel", 0)
                                            }));
            }
            else if (employee.Type > EmployeeType.ServiceDesk)
            {
                //The higher-level employees can see the tickets with escalation level corresponding to their type minus 1.
                matchForEmployeeLevel = new BsonDocument("$match", new BsonDocument("escalationLevel", (int)employee.Type - 1));
            }
            else
            {
                // Everyone else can see tickets that belong to them.
                matchForEmployeeLevel = new BsonDocument("$match", new BsonDocument("reporter", employee.Id));
            }

            return new List<BsonDocument>(){ lookUp, unwind, matchForEmployeeLevel };
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
        public StatusStruct GetTickets(out List<Ticket> output, Employee employee)
        {
            try
            {
                var bsonOutput = ticketsdb.Get(GetTicketPipeline(employee));
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

        /// <summary>
        /// Gets a list of Tickets by status from a specific employee
        /// </summary>
        /// <param name="status">Ticket status to filter by.</param>
        /// <param name="employee">Employee to find specific tickets for.</param>
        public List<Ticket> GetTicketsByStatus(TicketStatus status, Employee employee)
        {
            try
            {
                // Create stages for the pipeline
                var pipeline = GetTicketPipeline(employee);
                if (status != TicketStatus.PastDeadline) // If the ticket isn't past the deadline date...
                {
                    pipeline.Add(new BsonDocument("$match", new BsonDocument("status", (int)status)));
                }
                else // Filter by tickets that are past the deadline date & have an open status
                {
                    pipeline.Add(new BsonDocument("$match", new BsonDocument("deadline", new BsonDocument("$lte", DateTime.Now))));
                    pipeline.Add(new BsonDocument("$match", new BsonDocument("status", (int)TicketStatus.Open)));
                }

                // Return tickets by status
                return ConvertToTicketList(ticketsdb.Get(pipeline));
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                return new List<Ticket>();
            }
        }

        /// <summary>
        /// Returns the ticket by its ID.
        /// </summary>
        /// <param name="ticketId">Ticket ID to look for.</param>
        public StatusStruct GetById(int ticketId, out Ticket output, Employee employee)
        {
            try
            {
                var pipeline = GetTicketPipeline(employee);
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

        /// <summary>
        /// Gets amount of total tickets that are not escalated.
        /// </summary>
        public int GetTotalTicketCount()
        {
            try
            {
                // Create a filter that checks for non-escalated tickets
                var builder = Builders<Ticket>.Filter;
                var filter = builder.Eq("escalationLevel", BsonNull.Value) | 
                                builder.Eq("escalationLevel", 0);

                // Get total ticket count
                return (int)ticketsdb.GetTotalTicketCount(filter);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                return -1;
            }
        }

        /// <summary>
        /// Gets amount of tickets by status that are not escalated.
        /// </summary>
        /// <param name="status">Ticket status to filter by.</param>
        public int GetTicketCountByType(TicketStatus status)
        {
            try
            {
                // Create a filter that checks for non-escalated tickets and by status
                FilterDefinitionBuilder<Ticket> builder = Builders<Ticket>.Filter;
                FilterDefinition<Ticket> filter; 
                if (status != TicketStatus.PastDeadline)
                {
                    filter = (builder.Eq("escalationLevel", BsonNull.Value) |
                                    builder.Eq("escalationLevel", 0)) &
                                    builder.Eq("status", (int)status);
                }
                else // Look for open tickets that are past the deadline
                {
                    filter = (builder.Eq("escalationLevel", BsonNull.Value) |
                                builder.Eq("escalationLevel", 0)) &
                                builder.Eq("status", (int)TicketStatus.Open) &
                                builder.Lte("deadline", DateTime.Now);
                }

                // Return the count by ticket status
                return (int)ticketsdb.GetTicketCountByStatus(filter);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                return -1;
            }
        }

        /// <summary>
        /// Inserts a new ticket into the database.
        /// </summary>
        /// <param name="date">Date of ticket submission.</param>
        /// <param name="subject">Subject of the ticket.</param>
        /// <param name="type">Incident Type</param>
        /// <param name="reporter">Person who reports the incident.</param>
        /// <param name="priority">Priority of the incident.</param>
        /// <param name="followUpDays">How many days until the ticket's deadline?</param>
        /// <param name="description">Brief description of the issue.</param>
        /// <returns>Returns if sent successfully, and/or issues with the submission.</returns>
        public StatusStruct InsertTicket(DateTime date, string subject, IncidentTypes type, Employee reporter, TicketPriority priority, int followUpDays, string description)
        {
            string issues = "";
            if (!IsTicketSubmissionValid(ref issues, date, subject, type, reporter, priority, followUpDays, description))
            {
                return new StatusStruct(1, issues);
            }

            try
            {
                BsonDocument doc = new BsonDocument
                {
                    new BsonElement("_id", GetHighestId() + 1),
                    new BsonElement("type", (int)type),
                    new BsonElement("subject", subject),
                    new BsonElement("description", description),
                    new BsonElement("reporter", reporter.Id),
                    new BsonElement("date", date),
                    new BsonElement("deadline", date.AddDays(followUpDays)),
                    new BsonElement("priority", priority),
                    new BsonElement("status", TicketStatus.Open),
                    new BsonElement("escalationLevel", 0)
                };

                ticketsdb.Insert(doc);
                return new StatusStruct(0);
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
            // Subject or description empty? Return status as 1.
            if (!IsTicketEditValid(out string issues, subject, description, priority))
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
        protected int GetHighestId()
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
            catch (Exception ex) 
            { 
                ErrorHandler.Instance.WriteError(ex); 
            }

            return 0;
        }

        /// <summary>
        /// Checks if ticket submission is valid.
        /// </summary>
        private bool IsTicketSubmissionValid(ref string reason, DateTime date, string subject, IncidentTypes type, Employee employee, TicketPriority priority, int deadline, string description)
        {
            StringBuilder sb = new StringBuilder();
            if (date > DateTime.Now)
                sb.AppendLine("Incident time cannot be in the future");

            if (string.IsNullOrEmpty(subject))
                sb.AppendLine("Subject is missing");

            if ((int)type == -1)
                sb.AppendLine("Type of incident is not provided");

            if (employee == null)
                sb.AppendLine("Reporting user not provided");

            if ((int)priority == -1)
                sb.AppendLine("Priority not provided");

            if (deadline == -1)
                sb.AppendLine("Deadline not provided");

            if (string.IsNullOrEmpty(description))
                sb.AppendLine("Description not provided");

            reason = sb.ToString();
            return reason.Length == 0;
        }

        /// <summary>
        /// Returns true, if the ticket update submission is valid.
        /// </summary>
        private bool IsTicketEditValid(out string issues, string subject, string description, TicketPriority priority)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(subject))
                sb.AppendLine("Subject is empty");
            
            if (string.IsNullOrEmpty(description))            
                sb.AppendLine("Description is empty");

            if (priority == TicketPriority.ToBeDetermined)
                sb.AppendLine("Ticket priority must be defined");

            issues = sb.ToString();
            return issues.Length == 0;
        }

        /// <summary>
        /// Close the provided ticket.
        /// </summary>
        /// <param name="ticket">Ticket to Close.</param>
        public StatusStruct CloseTicket(Ticket ticket)
        {

            try
            {

                var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.Id);
                var update = Builders<BsonDocument>.Update.Set("IsClosed", true);

                ticketsdb.Update(filter, update);
                return new StatusStruct(0);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                return new StatusStruct(1, "Unable to update the ticket. Try again later.");
            }
        }
    }
}