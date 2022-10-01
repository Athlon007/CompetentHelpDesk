using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;



namespace Model
{
    public class DatabasesModel
    { 

        public DatabasesModel(string name, double size, bool empty)
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

        
  
    }
}
