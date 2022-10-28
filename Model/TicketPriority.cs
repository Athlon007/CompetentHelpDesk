using System.ComponentModel;

namespace Model
{
    public enum TicketPriority
    {
        [Description("To Be Determined")]
        ToBeDetermined = 0,
        Low = 1,
        Medium = 2, 
        High = 3
    }
}
