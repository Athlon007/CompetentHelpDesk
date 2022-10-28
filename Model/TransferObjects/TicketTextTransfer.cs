namespace Model
{
    public struct TicketTextTransfer
    {
        /// <summary>
        /// Ticket's subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Ticket's description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Create ticket text data transfer object.
        /// </summary>
        /// <param name="subject">Ticket's subject.</param>
        /// <param name="description">Ticket's description</param>
        public TicketTextTransfer(string subject, string description)
        {
            Subject = subject; 
            Description = description;
        }
    }
}
