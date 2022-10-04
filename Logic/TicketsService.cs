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
            // TODO: Implement this function
            return 19; // Dummy data...

            // Get filter by type
            string filter = GetTicketCountByTypeFilter(status);

            try
            {
                return ticketsdb.GetTicketCountByType(filter);
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

        private string GetTicketCountByTypeFilter(TicketStatus status)
        {
            // TODO: Rewrite it (?)
            // Get filter word with appropiate enum
            switch (status)
            {
                case TicketStatus.PastDeadline:
                    return "pastdeadline";
                case TicketStatus.Unresolved:
                    return "unresolved";
                case TicketStatus.Resolved:
                    return "resolved";
                default:
                    return "open";
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
    }
}