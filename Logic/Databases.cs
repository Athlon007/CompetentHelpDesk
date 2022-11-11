using DAL;
using Model;
using System.Collections.Generic;


namespace Logic
{
    public class Databases
    {
        private BaseDAO baseDao;
        public Databases()
        {
            baseDao = new BaseDAO();
        }

        public List<DatabasesModel> GetDatabases()
        {
            return baseDao.GetDatabases();
        }

    
    }
}
