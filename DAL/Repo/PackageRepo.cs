using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class PackageRepo : IPackageRepo<Package, int>
    {
        TMSAPIEntities db;

        public PackageRepo(TMSAPIEntities db)
        {
            this.db = db;
        }
        public List<Package> Get()
        {
            return db.Packages.ToList();
        }

        public Package Get(int id)
        {
            return db.Packages.FirstOrDefault(c => c.packageid == id);
        }
    }
}
