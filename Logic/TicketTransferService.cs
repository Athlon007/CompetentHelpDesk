using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TicketTransferService
    {
        protected TicketsDAO ticketsdb;

        public TicketTransferService()
        {
            ticketsdb = new TicketsDAO();
        }
        public StatusStruct TransferTicket(Ticket ticket, Employee employee)
        {

            try
            {

                ticket.AssignedEmployee = employee;

                var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.Id);
                var update = Builders<BsonDocument>.Update.Set("assignedEmployee", ticket.AssignedEmployee.Id);

                ticketsdb.Update(filter, update);
                return new StatusStruct(0);
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                return new StatusStruct(1, "Unable to transfer the ticket. Try again later.");
            }
        }
    }
}
