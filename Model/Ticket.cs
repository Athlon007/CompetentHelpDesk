using System;
using MongoDB.Bson;
using System.Runtime.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    [BsonIgnoreExtraElements]
    public class Ticket
    {
        [BsonId]
        [DataMember]
        public int Id { get; set; }

        [BsonElement("type")]
        public IncidentTypes IncidentType { get; set; }
        [BsonElement("subject")]
        public string Subject { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("reporterPerson")]
        public Employee Reporter { get; set; }
        [BsonElement("date")]
        public DateTime Date { get; set; }
        [BsonElement("deadline")]
        public DateTime Deadline { get; set; }
        [BsonElement("priority")]
        public TicketPriority Priority { get; set; }
        [BsonElement("status")]
        public TicketStatus Status { get; set; }
        [BsonElement("escalationLevel")]
        [BsonIgnoreIfNull]
        public int EscalationLevel { get; set; }

        public override string ToString()
        {
            return $"({Id}, {IncidentType}) Subject: {Subject}\n" +
                $"Description: {Description}\n" +
                $"Date: {Date}\n" +
                $"Deadline: {Deadline}\n" +
                $"Prority: {Priority}\n" +
                $"Status:{Status}\n" +
                $"Escalation Level: {EscalationLevel}" +
                $"  Employee:{Reporter}";
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

        public override bool Equals(object obj)
        {
            if (obj is Ticket)
            {
                return (obj as Ticket).Id == this.Id;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() + Subject.GetHashCode() + Description.GetHashCode();
        }
    }
}
