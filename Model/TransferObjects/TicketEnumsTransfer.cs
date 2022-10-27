namespace Model
{
    public struct TicketEnumsTransfer
    {
        /// <summary>
        /// Type of an incident.
        /// </summary>
        public IncidentTypes IncidentType { get; set; }

        /// <summary>
        /// Incident's priority.
        /// </summary>
        public TicketPriority Priority { get; set; }

        /// <summary>
        /// Ticket's status.
        /// </summary>
        public TicketStatus Status { get; set; }

        /// <summary>
        /// Ticket's escalation level.
        /// </summary>
        public int EscalationLevel { get; set;}

        /// <summary>
        /// Create ticket enumerables transfer object, with default status and escalation level.
        /// </summary>
        /// <param name="incidentType">Type of the incident.</param>
        /// <param name="priority">Ticket's priority.</param>
        public TicketEnumsTransfer(IncidentTypes incidentType, TicketPriority priority)
        {
            IncidentType = incidentType;
            Priority = priority;
            Status = TicketStatus.Open; 
            EscalationLevel = 0;
        }

        /// <summary>
        /// Create ticket enumerables transfer object, with the default escalation level.
        /// </summary>
        /// <param name="incidentType">Type of the incident.</param>
        /// <param name="priority">Ticket's priority.</param>
        /// <param name="status">Status of the ticket.</param>
        public TicketEnumsTransfer(IncidentTypes incidentType, TicketPriority priority, TicketStatus status)
        {
            IncidentType = incidentType;
            Priority = priority;
            Status = status;
            EscalationLevel = 0;
        }

        /// <summary>
        /// Create ticket enumerables transferr object.
        /// </summary>
        /// <param name="incidentType">type of the incident.</param>
        /// <param name="priority">Ticket's priority.</param>
        /// <param name="status">Status of the ticket.</param>
        /// <param name="escalationLevel">Escalation level.</param>
        public TicketEnumsTransfer(IncidentTypes incidentType, TicketPriority priority, TicketStatus status, int escalationLevel)
        {
            IncidentType = incidentType;
            Priority = priority;
            Status = status;
            EscalationLevel = escalationLevel;
        }
    }
}
