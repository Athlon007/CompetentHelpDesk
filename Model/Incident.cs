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
    public class Incident
    {

        //used string data type for deserialization into instances of the class
        int id;
        string subject;
        int userId;
        IncidentTypes incidentType;
        DateTime loggedOn;
        string description;


        [BsonId]
        [DataMember]
        
        public MongoDB.Bson.ObjectId _id { get; set; }

        public int Id { get { return id; } set { id = value; } }

        public string Subject { get { return subject; } set { subject = value; } }    

        public int UserId { get { return userId; } set { userId = value; } }

        public IncidentTypes IncidentType { get { return incidentType; } set { incidentType = value; } }

        public DateTime LoggedOn { get { return loggedOn; } set { loggedOn = value; } }

        public string Description { get { return description; } set { description = value; } }


        public Incident(int id, string subject, int userId, IncidentTypes incidentType, DateTime loggedOn, string description)
        {
            Id = id;
            Subject = subject;
            UserId = userId;
            IncidentType = incidentType;
            LoggedOn = loggedOn;
            Description = description;
        }

    }
}
