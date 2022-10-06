using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;

namespace TestDbConnectionNew
{
    [TestClass]
    public class TestTickets
    {
        private TicketsService service;
        private List<Ticket> tickets;

        public TestTickets()
        {
            service = new TicketsService();
            service.GetTickets(out tickets);
        }

        [TestMethod]
        public void TicketsAreNotNull()
        {
            foreach (Ticket ticket in tickets)
            {
                Trace.WriteLine(ticket + "\n");
            }
            Assert.IsNotNull(tickets);
        }

        [TestMethod]
        public void TicketHasAssignedEmployee()
        {
            Assert.IsNotNull(tickets[0].Reporter);
        }

        [TestMethod]
        public void TicketDeadlineTime()
        {
            DateTime deadline = new DateTime(2022, 10, 14, 12, 00, 00);
            int expectedLength = (deadline - DateTime.Now).Days;
            Trace.WriteLine("Expected days: " + expectedLength);
            Ticket t = new Ticket()
            {
                IncidentType = IncidentTypes.Software,
                Subject = "Example", 
                Description = "Example", 
                Reporter = new Employee(), 
                Date = new DateTime(), 
                Deadline = deadline, 
                Priority = TicketPriority.Medium, 
                Status = TicketStatus.Open
            };
            Assert.AreEqual(expectedLength, t.DaysUntilDeadline);
        }

        [TestMethod]
        public void GetTickedByID()
        {
            var response = service.GetById(0, out Ticket t);
            Trace.WriteLine($"Ticket 0 details: " + t);
            Assert.AreEqual(0, response.Code);
        }

        [TestMethod]
        public void TestInsertValidationTrue()
        {
            PrivateObject obj = new PrivateObject(service);
            var retVal = obj.Invoke("IsTicketSubmissionValid", "", DateTime.Now, "Subject", IncidentTypes.Service, new Employee(), TicketPriority.Low, 7, "Description");
            Assert.AreEqual(true, retVal);
        }

        [TestMethod]
        public void TestInsertValidationFalse()
        {
            PrivateObject obj = new PrivateObject(service);
            var retVal = obj.Invoke("IsTicketSubmissionValid", "", DateTime.Now, "", IncidentTypes.Service, new Employee(), TicketPriority.Low, 7, "Description");
            Assert.AreEqual(false, retVal);
        }

        [TestMethod]
        public void HighestId()
        {
            PrivateObject obj = new PrivateObject(service);
            var retVal = obj.Invoke("GetHighestId");
            Trace.WriteLine($"Highest ID is: {retVal}");
            Assert.AreNotEqual(0, retVal);
        }

        [TestMethod]
        public void TestEditValidationTrue()
        {
            PrivateObject obj = new PrivateObject(service);
            var retVal = obj.Invoke("IsTicketEditValid", "", "Subject", "Description");
            Assert.AreEqual(true, retVal);
        }

        [TestMethod]
        public void TestEditValidationFalse()
        {
            PrivateObject obj = new PrivateObject(service);
            var retVal = obj.Invoke("IsTicketEditValid", "", "", "Description");
            Assert.AreEqual(false, retVal);
        }
    }
}
