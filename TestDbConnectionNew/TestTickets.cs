using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestDbConnectionNew
{
    [TestClass]
    public class TestTickets
    {
        private TicketsService service;
        private List<Ticket> tickets;
        private Employee testEmployee;

        public TestTickets()
        {
            testEmployee = new Employee();
            testEmployee.Id = 0;
            service = new TicketsService();
            service.GetTickets(out tickets, testEmployee);
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
            Trace.WriteLine("Ticket 0 reporter: " + tickets[0].Reporter);
            Assert.IsNotNull(tickets[0].Reporter);
        }

        [TestMethod]
        public void TicketDeadlineTime()
        {
            DateTime deadline = new DateTime(2022, 10, 14, 12, 00, 00);
            int expectedLength = (deadline - DateTime.Now).Days;
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
            Trace.WriteLine("Expected days: " + expectedLength);
            Trace.WriteLine("Actual days: " + t.DaysUntilDeadline);
            Assert.AreEqual(expectedLength, t.DaysUntilDeadline);
        }

        [TestMethod]
        public void GetTickedByID()
        {
            var response = service.GetById(0, out Ticket t, testEmployee);
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
            object[] args = new object[] { "", DateTime.Now, "", IncidentTypes.Service, new Employee(), TicketPriority.Low, 7, "Description" };
            var retVal = obj.Invoke("IsTicketSubmissionValid", args);
            Trace.WriteLine("Response: " + args[0]);
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
        public void TestTicketUpdateTrue()
        {
            PrivateObject obj = new PrivateObject(service);
            object[] args = new object[] { null, "Subject", "Description", TicketPriority.Low };
            var retVal = obj.Invoke("IsTicketEditValid", args);
            Trace.WriteLine($"Responce: " + args[0]);
            Assert.AreEqual(true, retVal);
        }

        [TestMethod]
        public void TestTicketUpdateFalse()
        {
            PrivateObject obj = new PrivateObject(service);
            object[] args = new object[] { null, "", "", TicketPriority.ToBeDetermined };
            var retVal = obj.Invoke("IsTicketEditValid", args);
            Trace.WriteLine($"Responce: " + args[0]);
            Assert.AreEqual(false, retVal);
        }
    }
}
