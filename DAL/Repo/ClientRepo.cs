using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
     public class ClientRepo : IRepository<Client, int>
    {
        TMSAPIEntities db;
        public ClientRepo(TMSAPIEntities db)
        {
            this.db = db;
        }

        public void Add(Client e)
        {
            this.db.Clients.Add(e);
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            var clnt = db.Clients.FirstOrDefault(c => c.clientid == id);
            db.Clients.Remove(clnt);
            db.SaveChanges();
        }

        public void Edit(Client e)
        {
            var b = db.Clients.FirstOrDefault(en => en.clientid == e.clientid);
            db.Entry(b).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Client> Get()
        {
            return db.Clients.ToList();
        }

        public Client Get(int id)
        {
            return db.Clients.FirstOrDefault(c => c.clientid == id);
        }
    }
}
