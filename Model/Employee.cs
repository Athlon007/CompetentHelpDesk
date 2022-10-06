using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using MongoDB.Bson;


namespace Model
{
    public class Employee
    {
        //used string data type for deserialization into instances of the class

        [BsonId]
        [DataMember]
        public int Id { get; set; }

        [BsonElement("email")]
        public string Email { get; private set; }
        [BsonElement("username")]
        public string Username { get; private set; }
        [BsonElement("firstname")]
        public string FirstName { get; private set; }
        [BsonElement("lastname")]
        public string LastName { get; private set; }
        [BsonElement("type")]
        public EmployeeType Type { get; private set; }
        [BsonElement("password")]
        public string PasswordHash { get ; private set; }
        [BsonElement("salt")]
        public string Salt { get; private set; }

        public Employee() { }

        public Employee(int id, string email, string username, string firstName, string lastName, string passwordHash, string salt)
        {
            this.Email = email;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PasswordHash = passwordHash;
            this.Salt = salt;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} [ {Id} ]";
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                return ((Employee)obj).Id == this.Id;
            }

            return base.Equals(obj);
        }
    }
}
