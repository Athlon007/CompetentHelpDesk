using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Runtime.Serialization;

namespace Model
{

    public class ArchivedTicket
    {

        private int id;
        private IncidentTypes incidentType;
        private string subject;
        private string description;
        private Employee reporter;
        private int ticketId;
        private DateTime date;
        private DateTime deadline;
        private TicketPriority priority;
        private TicketStatus status;
        private int escalationLevel;
        private bool isClosed;
        private DateTime archivingDate;


        [BsonId]
        [DataMember]

        public MongoDB.Bson.ObjectId _id { get; set; }


        public int Id { get { return id; } set { id = value; } }
        public IncidentTypes IncidentType { get { return incidentType; } set { incidentType = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string Description { get { return description; } set { description = value; } }
        public Employee Reporter { get { return reporter; } set { reporter = value; } }    
        public int TicketId { get { return ticketId; } set { ticketId = value; } }
        public DateTime Date { get { return date; } set { date = value; } }   
        public DateTime Deadline { get { return deadline; } set { deadline = value; } }

        public TicketPriority Priority { get { return priority; } set { priority = value; } }

        public TicketStatus Status { get { return status; } set { status = value; } }

        public int EscalationLevel { get { return escalationLevel; } set { escalationLevel = value; } }
            
        public bool IsClosed { get { return isClosed; } set { isClosed = value; } }   

        public DateTime ArchivingDate { get { return archivingDate; } set { archivingDate = value; } } 

    }
}
