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
        EmployeesDAO employeeDAO = new EmployeesDAO();
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
            List<Databases_Model> databases = dao.GetDatabases();   
            dao.Test(databases);

            TestEmployeeDatabase();
            TestTicketsDatabase();

            TestDeserializer();
        }

        void TestEmployeeDatabase() {

            IMongoCollection<BsonDocument> employees = employeeDAO.GetAllEmployees();

            var docs = employees.Find(new BsonDocument()).ToList();

            docs.ForEach(doc =>
            {
                Console.WriteLine(doc);
            });

            BsonDocument employee = employeeDAO.GetById("1");

            Console.WriteLine($"Employee {employee.GetElement("Id")}");
            Console.WriteLine($"{employee.GetElement("Username")}");
        }


        void TestTicketsDatabase()
        {
            IMongoCollection<BsonDocument> tickets = ticketsDAO.GetAllTickets();

            var docs = tickets.Find(new BsonDocument()).ToList();

            docs.ForEach(doc =>
            {
                Console.WriteLine(doc);
            });


            BsonDocument ticket = ticketsDAO.GetById("1");

            Console.WriteLine($"Ticket {ticket.GetElement("Id")}");
            Console.WriteLine($"{ticket.GetElement("UserId")}");
        }



        void TestDeserializer() 
        {
            Employee employee = new Employee();

            BsonDocument employeeBsonDocument = employeeDAO.GetById("1");

            Employee employeeClassInstance = employee.ConvertDocumentToObject(employeeBsonDocument);

            Console.WriteLine(employeeClassInstance.GetType());

            Console.WriteLine(employeeClassInstance.Id);
            Console.WriteLine(employeeClassInstance.Username);

        }

    }

}