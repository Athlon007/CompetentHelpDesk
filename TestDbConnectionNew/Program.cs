using System;
using System.Collections.Generic;
using System.IO;
using Model;
using Logic;


namespace TestDbConnectionNew
{
    class Program
    {
        Databases baseDAO = new Databases();
        EmployeeService employeesDAO = new EmployeeService();
        TicketsService ticketsDAO = new TicketsService();


        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        void Start()
        {
            //TestDbConnection();
            TestEmployeeDatabase();
            TestTicketDatabase();
        }

        void TestDbConnection()
        {
            List<DatabasesModel> databases = baseDAO.GetDatabases();
            TestDbConnection(databases);


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

        void TestEmployeeDatabase()
        {

            var employees = employeesDAO.GetEmployees();

            Console.WriteLine("Printing employees list:");
            foreach (Employee employ in employees)
            {
                Console.WriteLine(employ);
            }
        }

        void TestTicketDatabase()
        {

            var tickets = ticketsDAO.GetTickets();

            Console.WriteLine("Printing tickets list:");
            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine(ticket);
            }
        }
    }

}