using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        int id;
        string subject;
        int userId;
        DateTime date;
        string status;

        public Ticket(int id, string subject, int userId, DateTime date, string status)
        {
            this.id = id;
            this.subject = subject;
            this.userId = userId;
            this.date = date;
            this.status = status;
        }
    }
}
