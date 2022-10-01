using DAL;
using Model;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;

namespace Logic
{
    public class Databases
    {
        private BaseDAO baseDao;
        public Databases()
        {
            baseDao = new BaseDAO();
        }

        public List<Databases_Model> Get_All_Databases()
        {
            return baseDao.GetDatabases();
        }

        public int RetrieveDocumentsCount(IMongoCollection<BsonDocument> db)
        {
            return baseDao.RetrieveDocumentsCount(db);  

        }
    }
}
