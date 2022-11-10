using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using DAL;

namespace Logic
{
    public class EmployeeService
    {
        private EmployeesDAO employeedb;

        public EmployeeService()
        {
            employeedb = new EmployeesDAO();
        }

        private List<Employee> ConvertToEmployeeList(IAsyncCursor<BsonDocument> cursor)
        {
            List<Employee> list = new List<Employee>();
            foreach (var entry in cursor.ToEnumerable())
            {
                Employee employee = BsonSerializer.Deserialize<Employee>(entry);
                list.Add(employee);
            }
            return list;
        }

        public List<Employee> GetEmployees()
        {
            return ConvertToEmployeeList(employeedb.Get());
        }

        public Employee GetById(int employeeId)
        {
            Employee employee = employeedb.GetById(employeeId);
            return employee;
        }

        public Employee GetByUsername(string username)
        {
            Employee employee = employeedb.GetByUsername(username);
            return employee;
        }

        public Employee ConvertDocumentToObject(BsonDocument bsonDocument) 
        { 
            return employeedb.ConvertDocumentToObject(bsonDocument);    
        
        }
        public List<Employee> GetEmployeesByType(EmployeeType employeeType)
        {
            List<BsonDocument> pipeline = new List<BsonDocument>() { new BsonDocument("$match", new BsonDocument("type", employeeType)) };
            return ConvertToEmployeeList(employeedb.Get(pipeline));
        }

        public string GetRandomPassword(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
        protected int GetHighestId()
        {
            try
            {
                var project = new BsonDocument("$project",
                              new BsonDocument("_id", 1));
                var sort = new BsonDocument("$sort",
                           new BsonDocument("_id", -1));
                var limit = new BsonDocument("$limit", 1);

                var pipeline = new[] { project, sort, limit };

                var output = employeedb.Get(pipeline).ToList();
                if (output.Count > 0)
                {
                    return (int)output.First().GetValue(0);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
            }

            return 0;
        }

        public StatusStruct CreateUser(string email, string username, string firstname, string lastname, EmployeeType type, string passwordHash, string salt)
        {

            try
            {
                BsonDocument doc = new BsonDocument
                {
                    new BsonElement("_id", GetHighestId() + 1),
                    new BsonElement("email", email),
                    new BsonElement("username", username),
                    new BsonElement("firstname", firstname),
                    new BsonElement("lastname", lastname),
                    new BsonElement("type", type),
                    new BsonElement("password", passwordHash),
                    new BsonElement("salt", salt)

                };

                employeedb.Insert(doc);
                return new StatusStruct(0, "");
            }
            catch (Exception ex)
            {
                ErrorHandler.Instance.WriteError(ex);
                return new StatusStruct(1, "Couldn't send data to the server. Try again later.");
            }
        }
    }
}