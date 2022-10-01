using System;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using System.IO;
using DAL;
using Model;


namespace ConnectToDatabase
{
    class Program
    {
        DAO dao = new DAO();
        EmployeesDAO employeesDAO = new EmployeesDAO();
        TicketDAO ticketsDAO = new TicketDAO();


        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            TestDbConnection();
        }

        void TestDbConnection()
        {
            List<Databases_Model> databases = dao.GetDatabases();   
            dao.Test(databases);

            TestEmployeeDatabase();
            TestTicketsDatabase();

            TestDeserializer();
        }

        void TestEmployeeDatabase() {

            IMongoCollection<BsonDocument> employees = employeesDAO.GetAllEmployees();

            var docs = employees.Find(new BsonDocument()).ToList();

            Console.WriteLine("Printing employees list:");
            docs.ForEach(doc =>
            {
                Console.WriteLine(doc);
            });

            BsonDocument employee = employeesDAO.GetById("1");

            Console.WriteLine("Printing one employee data");
            Console.WriteLine($"Employee {employee.GetElement("Id")}");
            Console.WriteLine($"{employee.GetElement("Username")}");
            Console.WriteLine();
        }


        void TestTicketsDatabase()
        {
            IMongoCollection<BsonDocument> tickets = ticketsDAO.GetAllTickets();

            var docs = tickets.Find(new BsonDocument()).ToList();

            Console.WriteLine("Printing tickets list:");
            docs.ForEach(doc =>
            {
                Console.WriteLine(doc);
            });


            BsonDocument ticket = ticketsDAO.GetById("1");

            Console.WriteLine("Printing one ticket data");
            Console.WriteLine($"Ticket {ticket.GetElement("Id")}");
            Console.WriteLine($"{ticket.GetElement("UserId")}");
            Console.WriteLine();
        }



        void TestDeserializer() 
        {
            Employee employee = new Employee();
            Ticket ticket = new Ticket();

            BsonDocument employeeBsonDocument = employeesDAO.GetById("1");
            BsonDocument ticketBsonDocument = ticketsDAO.GetById("1");

            Employee employeeClassInstance = employee.ConvertDocumentToObject(employeeBsonDocument);
            Ticket ticketClassInstance = ticket.ConvertDocumentToObject(ticketBsonDocument);

            Console.WriteLine($"Class: {employeeClassInstance.GetType()}");
            Console.WriteLine($"Employee id: {employeeClassInstance.Id}");
            Console.WriteLine($"Username: {employeeClassInstance.Username}");
            Console.WriteLine();

            Console.WriteLine($"Class: {ticketClassInstance.GetType()}");
            Console.WriteLine($"Ticket id: {ticketClassInstance.Id}");
            Console.WriteLine($"User id: {ticketClassInstance.UserId}");
            Console.WriteLine();
        }

    }

}