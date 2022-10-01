using System;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using System.IO;
using DAL;
using Model;
using Logic;


namespace ConnectToDatabase
{
    class Program
    {
        BaseDAO baseDAO = new BaseDAO();
        EmployeesDAO employeesDAO = new EmployeesDAO();
        TicketsDAO ticketsDAO = new TicketsDAO();


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
            List<DatabasesModel> databases = baseDAO.GetDatabases();   
            TestDbConnection(databases);

            TestEmployeeDatabase();
            TestTicketsDatabase();

            TestDeserializer();

            TestConvertingEmployeeDbToList();
            TestConvertingTicketsDbToTicketList();
        }


        public void TestDbConnection(List<DatabasesModel> dbs)
        {
           
            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbs)
            {
                Console.WriteLine($"Database: {db.name}");
                Console.WriteLine($"Size: {db.size}");
                Console.WriteLine($"IsEmpty: {db.empty}");
                Console.WriteLine();
            }
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

            Employee employeeClassInstance = employeesDAO.ConvertDocumentToObject(employeeBsonDocument);
            Ticket ticketClassInstance = ticketsDAO.ConvertDocumentToObject(ticketBsonDocument);

            Console.WriteLine($"Class: {employeeClassInstance.GetType()}");
            Console.WriteLine($"Employee id: {employeeClassInstance.Id}");
            Console.WriteLine($"Username: {employeeClassInstance.Username}");
            Console.WriteLine();

            Console.WriteLine($"Class: {ticketClassInstance.GetType()}");
            Console.WriteLine($"Ticket id: {ticketClassInstance.Id}");
            Console.WriteLine($"User id: {ticketClassInstance.UserId}");
            Console.WriteLine();
        }



        void TestConvertingEmployeeDbToList()
        {
            IMongoCollection<BsonDocument> employees = employeesDAO.GetAllEmployees();

            int count = employeesDAO.RetrieveDocumentsCount(employees);

            Console.WriteLine($"Number of employees: {count}");

            List<Employee> employeesList = employeesDAO.ConvertAllDocumentsToEmployeesList(employees);

            Console.WriteLine("The list of employees by their usernames:");

            for (int i = 0; i < employeesList.Count; i++)
            {
                Console.WriteLine(employeesList[i].Username);
            }
            Console.WriteLine();


        }



        void TestConvertingTicketsDbToTicketList()
        {
            IMongoCollection<BsonDocument> tickets = ticketsDAO.GetAllTickets();

            int count = ticketsDAO.RetrieveDocumentsCount(tickets);

            Console.WriteLine($"Number of tickets: {count}");

            List<Ticket>ticketsList = ticketsDAO.ConvertAllDocumentsToTicketsList(tickets);

            Console.WriteLine("The list of tickets by their subject:");

            for (int i = 0; i < ticketsList.Count; i++)
            {
                Console.WriteLine(ticketsList[i].Subject);
            }
            Console.WriteLine();

        }

    }

}