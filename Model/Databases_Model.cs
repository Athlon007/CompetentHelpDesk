using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;



namespace Model
{
    public class Databases_Model
    { 

        public Databases_Model(string name, double size, bool empty)
        {
            this.name = name;
            this.size = size;
            this.empty = empty;
 
        }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("sizeOnDisk")]
        public double size { get; set; }

        [BsonElement("empty")]
        public bool empty { get; set; }

        
        public Employee Employee { get; set; }

        public Ticket Ticket { get; set; }

    }
}
