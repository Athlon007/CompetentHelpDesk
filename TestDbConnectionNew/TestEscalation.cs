using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;

namespace TestDbConnectionNew
{
    [TestClass]
    public class TestEscalation
    {
        private TicketEscalationService service;

        public TestEscalation()
        {
            service = new TicketEscalationService();
        }

        [TestMethod]
        public void TestTicketEscalatableTrue()
        {
            Ticket ticket = new Ticket();
            ticket.EscalationLevel = 0;
            Assert.AreEqual(true, service.IsTicketEscalatable(ticket));
        }

        [TestMethod]
        public void TestTicketEscalatableFalse()
        {
            int maxLevels = Enum.GetValues(typeof(EmployeeType)).Length;
            Ticket ticket = new Ticket();
            ticket.EscalationLevel = maxLevels;
            Assert.AreEqual(false, service.IsTicketEscalatable(ticket));
        }
    }
}
