namespace Model
{
    public struct TicketEmployeeTransfer
    {
        /// <summary>
        /// Employee which reported the issue.
        /// </summary>
        public Employee Reporter { get; set; }

        /// <summary>
        /// Employee tasked with fixing the ticket.
        /// </summary>
        public Employee AssignedEmployee { get; set; }

        /// <summary>
        /// Create data transfer object for employee info.
        /// </summary>
        /// <param name="Reporter">Employee which reported the incident.</param>
        /// <param name="AssignedEmployee">Employee tasked with fixing the ticket.</param>
        public TicketEmployeeTransfer(Employee Reporter, Employee AssignedEmployee)
        {
            this.Reporter = Reporter;
            this.AssignedEmployee = AssignedEmployee;
        }
    }
}
