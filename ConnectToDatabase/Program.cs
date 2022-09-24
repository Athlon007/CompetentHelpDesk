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
            DAO dao = new DAO();
            List<Databases_Model> databases = dao.GetDatabases();   
            dao.Test(databases);

            TestEmployeeDatabase();
            TestTicketsDatabase();
        }

        void TestEmployeeDatabase() {

            EmployeeDAO employeeDAO = new EmployeeDAO();
             
            IMongoCollection<BsonDocument> employees = employeeDAO.GetAllEmployees();

            var docs = employees.Find(new BsonDocument()).ToList();

            docs.ForEach(doc =>
            {
                Console.WriteLine(doc);
            });

        }

        void TestTicketsDatabase()
        {

            TicketsDAO ticketsDAO = new TicketsDAO();

            IMongoCollection<BsonDocument> tickets = ticketsDAO.GetAllTickets();

            var docs = tickets.Find(new BsonDocument()).ToList();

            docs.ForEach(doc =>
            {
                Console.WriteLine(doc);
            });

        }

    }

}