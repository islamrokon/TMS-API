using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class BookingRepo : IBookingRepo<Booking, int>
    {
        TMSAPIEntities db;

        public BookingRepo(TMSAPIEntities db)
        {
            this.db = db;
        }
        public void DeletePackage(int id)
        {
            var p = db.Bookings.FirstOrDefault(c => c.bookingid == id);
            db.Bookings.Remove(p);
            db.SaveChanges();
        }
        public void AddPackage(Booking e)
        {
            db.Bookings.Add(e);
            db.SaveChanges();
        }
        public List<Booking> GetPackage()
        {
            return db.Bookings.ToList();
        }

        public Booking GetPackage(int id)
        {
            return db.Bookings.FirstOrDefault(c => c.bookingid == id);
        }

    }
}
