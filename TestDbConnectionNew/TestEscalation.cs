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
            Employee employee = new Employee();
            employee.Type = EmployeeType.ServiceDesk;
            Ticket ticket = new Ticket();
            ticket.EscalationLevel = 0;
            Assert.AreEqual(true, service.IsTicketEscalatable(ticket, employee));
        }

        [TestMethod]
        public void TestTicketNotEscalatableDueToMaxLevel()
        {
            Employee employee = new Employee();
            employee.Type = EmployeeType.ServiceDesk;
            int maxLevels = Enum.GetValues(typeof(EmployeeType)).Length;
            Ticket ticket = new Ticket();
            ticket.EscalationLevel = maxLevels;
            Assert.AreEqual(false, service.IsTicketEscalatable(ticket, employee));
        }

        [TestMethod]
        public void TestTicketNotEscalatableDueToMaxEmployeeLevel()
        {
            Employee employee = new Employee();
            employee.Type = (EmployeeType)(Enum.GetValues(typeof(EmployeeType)).Length - 1);
            int maxLevels = Enum.GetValues(typeof(EmployeeType)).Length;
            Ticket ticket = new Ticket();
            ticket.EscalationLevel = maxLevels;
            Assert.AreEqual(false, service.IsTicketEscalatable(ticket, employee));
        }
    }
}
