using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IBookingRepo<T, ID>
    {
        List<T> GetPackage();
        T GetPackage(ID id);
        void AddPackage(T e);
        void DeletePackage(ID id);
    }
}
