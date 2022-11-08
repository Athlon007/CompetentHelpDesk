using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Model;

namespace DAL
{
    public class ArchivedTicketDAO : BaseDAO
    {

        private IMongoDatabase database;
        private List<BsonDocument> tickets;
        private IMongoCollection<BsonDocument> archivedTickets;
        private IMongoCollection<BsonDocument> ticketsDatabase;



        public ArchivedTicketDAO()
        {
            database = Client.GetDatabase("GardenGroup");
        }


        public List<BsonDocument> GetAllTicketsToCheckArchivingDate()
        {
            List<BsonDocument>tickets = database.GetCollection<BsonDocument>("Tickets").Find(new BsonDocument()).ToList();
            return tickets;
        }


        public List<BsonDocument> GetAllArchivedTickets()
        {
            List<BsonDocument> tickets = database.GetCollection<BsonDocument>("ArchivedTickets").Find(new BsonDocument()).ToList();
            return tickets;
        }


        //Using collection Tickets
        //deserialize document to use instance of class in the UI
        //to calculate the archiving date
        public Ticket ConvertDocumentToTicketInstanceForArchiving(BsonDocument bsonDocument)
        {
            Ticket instance = BsonSerializer.Deserialize<Ticket>(bsonDocument);

            return instance;
        }


        //Using collection ArchivedTickets
        //deserialize document to use instance of class in the UI
        public ArchivedTicket ConvertDocumentToArchivedTicketInstance(BsonDocument bsonDocument)
        {
            ArchivedTicket instance = BsonSerializer.Deserialize<ArchivedTicket>(bsonDocument);

            return instance;

        }


        public List<ArchivedTicket> ConvertAllDocumentsToArchivedTicketList(List<BsonDocument> archivedTicketsDb)
        {
            int dbdocuments = archivedTicketsDb.Count;
            List<ArchivedTicket> archivedTicketList = new List<ArchivedTicket>();
            if (dbdocuments > 0)
            {
                foreach(BsonDocument document in archivedTicketsDb) { 
                    ArchivedTicket archivedTicket = ConvertDocumentToArchivedTicketInstance((BsonDocument)document);
                    archivedTicketList.Add(archivedTicket);
                }
            }
            return archivedTicketList;
        }


        public void CreateArchivedTicket(BsonDocument document)
        {
            Database.GetCollection<BsonDocument>("ArchivedTickets").InsertOne(document);
        }


        public int RetrievePreviousDocumentId() 
        {
            List<BsonDocument> archivedTicketsDb = GetAllArchivedTickets();
            List<ArchivedTicket> archivedTicketsList = ConvertAllDocumentsToArchivedTicketList(archivedTicketsDb);
            int documentsCount = archivedTicketsDb.Count;
            int archivedTicketId;
            if (documentsCount == 0)
            { archivedTicketId = 0; }
            else
            {
              int previousArchivedTicketId = archivedTicketsList[archivedTicketsList.Count - 1].Id;

              archivedTicketId = ++previousArchivedTicketId; 
            }

            return archivedTicketId;    
        }


        public BsonDocument CreateDocumentFromArchivedTicketInstance(ArchivedTicket archivedTicket) 
        { 
        
           BsonDocument document = new BsonDocument { 
               { "Id", archivedTicket.Id },
                { "IncidentType", (int)archivedTicket.IncidentType },
                { "Subject", archivedTicket.Subject },
                { "Description", archivedTicket.Description },
                { "TicketId",archivedTicket.Id},
                { "Date", archivedTicket.Date},
                { "Deadline", archivedTicket.Deadline },
                { "Priority", (int)archivedTicket.Priority },
                { "Status", (int)archivedTicket.Status },
                { "EscalationLevel", archivedTicket.EscalationLevel},
                { "IsClosed", archivedTicket.IsClosed},
                { "ArchivingDate", archivedTicket.ArchivingDate }
        };


            return document;
    }


        public void RemoveArchivedTicketFromTicketDb(int id)
        {
            ticketsDatabase = database.GetCollection<BsonDocument>("Tickets");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("_id", id);
            var document = ticketsDatabase.Find(filter).FirstOrDefault();

            Database.GetCollection<Ticket>("Tickets").DeleteOne(document);
        }
    }
}
