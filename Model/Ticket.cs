using System;
using MongoDB.Bson;
using System.Runtime.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    [BsonIgnoreExtraElements]
    public class Ticket
    {
        /// <summary>
        /// Unique ticket ID.
        /// </summary>
        [BsonId]
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Type of incident (hardware, software, service).
        /// </summary>
        [BsonElement("type")]
        public IncidentTypes IncidentType { get; set; }

        /// <summary>
        /// Short ticket's subject.
        /// </summary>
        [BsonElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Description of a ticket.
        /// </summary>
        [BsonElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// Employee who reported the ticket.
        /// </summary>
        [BsonElement("reporterPerson")]
        public Employee Reporter { get; set; }

        /// <summary>
        /// Date when the ticket was registered into the system.
        /// </summary>
        [BsonElement("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Date, when the ticket is due.
        /// </summary>
        [BsonElement("deadline")]
        public DateTime Deadline { get; set; }

        /// <summary>
        /// Ticket's priority. Low, medium, or high.
        /// </summary>
        [BsonElement("priority")]
        public TicketPriority Priority { get; set; }

        /// <summary>
        /// The current status of a ticket.
        /// </summary>
        [BsonElement("status")]
        public TicketStatus Status { get; set; }

        /// <summary>
        /// The open or closed status of a ticket.
        /// </summary>
        [BsonElement("IsClosed")]

        public bool IsClosed { get; set; }

        /// <summary>
        /// Level of the escalation of the ticket. <br></br> 
        /// 0 = Support, <br></br>
        /// 1 = Specialist, <br></br>
        /// 2 = Management
        /// </summary>
        [BsonElement("escalationLevel")]
        [BsonIgnoreIfNull]
        public int EscalationLevel { get; set; }

        /// <summary>
        /// Support employee assigned to deal with the ticket.
        /// </summary>
        [BsonElement("assignedEmployee")]        
        public Employee AssignedEmployee { get; set; }

        public override string ToString()
        {
            return $"({Id}, {IncidentType}) Subject: {Subject}\n" +
                $"Description: {Description}\n" +
                $"Date: {Date}\n" +
                $"Deadline: {Deadline}\n" +
                $"Prority: {Priority}\n" +
                $"Status:{Status}\n" +
                $"Escalation Level: {EscalationLevel}\n" +
                $"  Reporter: {Reporter}\n" +
                $"  Employee: {AssignedEmployee}";
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

        /// <summary>
        /// Compare the ticket to another object.
        /// </summary>
        /// <param name="obj">Object to compare the ticket to</param>
        /// <returns>True, if ticket is the same.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Ticket ticket)
            {
                return ticket.Id == this.Id;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() + Subject.GetHashCode() + Description.GetHashCode();
        }
    }
}
