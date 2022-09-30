using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using System.Runtime.Serialization;
using MongoDB.Bson.Serialization.Attributes;




namespace Model
{
    public class Ticket
    {
        //used string data type for deserialization into instances of the class
        string id;
        string subject;
        string userId;
        string date;
        string status;

        [BsonId]
        [DataMember]
        public MongoDB.Bson.ObjectId _id { get; set; }

        [DataMember]
        public string Id { get { return id; } set { id = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string UserId { get { return userId; } set { userId = value; } }
        public string Date { get { return date; } set { date = value; } }
        public string Status { get { return status; } set { status = value; } }

        public Ticket(){}

        public Ticket(string id, string subject, string userId, string date, string status)
        {
            this.Id = id;
            this.Subject = subject;
            this.UserId = userId;
            this.Date = date;
            this.Status = status;
        }


        //Using collection Tickets
        //using the following script for data
        //db.Tickets.insertOne({'Id':'1', 'Subject': 'Subject', 'Userid': '1', 'Date':'24/09/2022', 'Status': 'Status'})

        //deserialize document to use instance of class in the UI
        public Ticket ConvertDocumentToObject(BsonDocument bsonDocument)
        {
            Ticket instance = BsonSerializer.Deserialize<Ticket>(bsonDocument);

            return instance;

        }
    }
}
