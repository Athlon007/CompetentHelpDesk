using System;

namespace Model
{
    public struct TicketDateTransfer
    {
        /// <summary>
        /// Ticket's date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Ticket's deadline days.
        /// </summary>
        public int DeadlineDays { get; set; }

        /// <summary>
        /// Create ticket dates data.
        /// </summary>
        /// <param name="Date">Date upon which the ticket was reported.</param>
        /// <param name="DeadlineDays">Number of days before the ticket's deadline.</param>
        public TicketDateTransfer (DateTime Date, int DeadlineDays)
        {
            this.Date = Date;
            this.DeadlineDays = DeadlineDays;
        }
    }
}
