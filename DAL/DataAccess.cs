using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        static TMSAPIEntities db = new TMSAPIEntities();
        public static IAuth AuthDataAccess()
        {
            return new AuthRepo(db);
        }

        public static IRepository<Client, int> ClientDataAccess()
        {
            return new ClientRepo(db);
        }
        public static IPackageRepo<Package, int> PacakgeDataAccess()
        {
            return new PackageRepo(db);
        }

        public static IBookingRepo<Booking, int> BookingDataAccess()
        {
            return new BookingRepo(db);
        }

    }
}
