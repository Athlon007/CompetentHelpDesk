﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;


namespace Model
{
    public class Employee
    {
        //used string data type for deserialization into instances of the class

        string id;
        string email;
        string username;
        string firstName;
        string lastName;
        string passwordHash;
        string salt;

        [BsonId]
        [DataMember]
        public MongoDB.Bson.ObjectId _id { get; set; }

        [DataMember]
        public string Id { get { return id; } set { id=value; } }
        public string Email{ get { return email; } set { email = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string  PasswordHash { get { return passwordHash; } set { passwordHash = value; } }
        public string Salt { get { return salt; } set { salt = value; } }

        public Employee() { }

        public Employee(string id, string email, string username, string firstName, string lastName, string passwordHash, string salt)
        {
            this.Id = id;
            this.Email = email;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PasswordHash = passwordHash;
            this.Salt = salt;
        }

        //Using collection Employees
        //using the following script for data
        // db.Employees.insertOne({'Id': '1', 'Email': 'someone@outlook.com', 'Username': 'Employee1', 'First name': 'First name', 'Last name': 'Last name', 'Password hash': 'PasswordHash', 'Salt':'Salt'})

        //deserialize document to use instance of class in the UI
        public Employee ConvertDocumentToObject(BsonDocument bsonDocument)
        {
            Employee instance = BsonSerializer.Deserialize<Employee>(bsonDocument);

            return instance;

        }
    }
}
