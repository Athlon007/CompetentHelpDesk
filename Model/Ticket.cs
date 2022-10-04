using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using System.Runtime.Serialization;
using MongoDB.Bson.Serialization.Attributes;




namespace Model
{
    public class Ticket
    {
        [BsonId]
        [DataMember]
        public int Id { get; set; }

        [BsonElement("subject")]
        public string Subject { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("reporter")]
        public Employee Reporter { get; set; }
        [BsonElement("date")]
        public DateTime Date { get; set; }
        [BsonElement("deadline")]
        public DateTime Deadline { get; set; }
        [BsonElement("priority")]
        public TicketPriority Priority { get; set; }
        [BsonElement("status")]
        public TicketStatus Status { get; set; }

        public Ticket() { }

        public Ticket(string subject, string description, Employee reporter, DateTime date, DateTime deadline, TicketPriority priority, TicketStatus status)
        {
            this.Subject = subject;
            this.Description = description;
            this.Reporter = reporter;
            this.Date = date;
            this.Deadline = deadline;
            this.Priority = priority;
            this.Status = status;
        }

        public override string ToString()
        {
            return $"({Id}) Subject: {Subject}\nDescription: {Description}\nDate: {Date}\nDeadline: {Deadline}\nPrority: {Priority}\nStatus:{Status}\n  Employee:{Reporter}";
        }

        /// <summary>
        /// Returns the number of days until the ticket's deadline
        /// </summary>
        public int DaysUntilDeadline
        {
            get
            {
                return (Deadline - DateTime.Now).Days;
            }
        }
    }
}
