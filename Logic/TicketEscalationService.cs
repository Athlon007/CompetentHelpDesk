using Model;
using DAL;
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace Logic
{
    public class TicketEscalationService
    {
        // Konrad Figura

        /// <summary>
        /// Escalates the ticket to higher level.
        /// </summary>
        /// <param name="ticket">Ticket to escalate.</param>
        /// <param name="escalatingEmployee">Currently logged-in employee, which is escalating the ticket.</param>
        public StatusStruct EscalateTicket(Ticket ticket, Employee escalatingEmployee)
        {
            if (!IsTicketEscalatable(ticket, escalatingEmployee))
            {
                return new StatusStruct(1, "Cannot escalate ticket further. Highest escalation level has been reached.");
            }

            if (ticket.Priority == TicketPriority.ToBeDetermined)
            {
                return new StatusStruct(1, $"Cannot escalate tickets with 'To Be Determined' status. Set the ticket priority first.");
            }

            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.Id);
                var update = Builders<BsonDocument>.Update.Set("escalationLevel", ticket.EscalationLevel + 1);
                TicketsDAO ticketsdb = new TicketsDAO();
                ticketsdb.Update(filter, update);
                return new StatusStruct(0);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                return new StatusStruct(1, "Unable to escalate the ticket. Try again later.");
            }
        }

        /// <summary>
        /// Checks if ticket can be escalated by the currently logged in employee.
        /// </summary>
        /// <param name="ticket">Ticket to chekc if can be escalated.</param>
        /// <param name="loggedInEmployee">Employee, that is currently logged in.</param>
        public bool IsTicketEscalatable(Ticket ticket, Employee loggedInEmployee)
        {
            int employeeLevels = Enum.GetValues(typeof(Employee)).Length;
            return ticket.EscalationLevel < employeeLevels - 2 && (int)loggedInEmployee.Type < employeeLevels - 2;
        }
    }
}
