using AutoMapper;
using BLL.Entity;
using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ClientService
    {
        TMSAPIEntities db = new TMSAPIEntities();
        //packages before add
        public static PackageModel Get(int uid)
        {
            var u = DataAccess.PacakgeDataAccess().Get(uid);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Package, PackageModel>());
            Mapper mapper = new Mapper(config);
            var d = mapper.Map<PackageModel>(u);
            return d;
        }
        public static List<PackageModel> Get()
        {
            var u = DataAccess.PacakgeDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Package, PackageModel>());
            Mapper mapper = new Mapper(config);
            var d = mapper.Map<List<PackageModel>>(u);
            return d;
        }
        public static bool Create(ClientModel c)
        {
            /*var config = new MapperConfiguration(cfg => cfg.CreateMap<Client, ClientModel>());
            Mapper mapper = new Mapper(config);
            var d = mapper.Map<Client>(c);*/
            Client d = new Client()
            {
                //clientid = c.clientid,
                clientemail = c.clientemail,
                clientname = c.clientname,
                clientcontact = c.clientcontact,
                password = c.password,
                username=c.username
            };
            DataAccess.ClientDataAccess().Add(d);
            return true;
        }
        public static bool Delete(int id)
        {
            DataAccess.ClientDataAccess().Delete(id);
            return true;
        }
        public static bool Edit(ClientModel c)
        {
            /*var config = new MapperConfiguration(cfg => cfg.CreateMap<Client, ClientModel>());
            Mapper mapper = new Mapper(config);
            var d = mapper.Map<Client>(c);*/
            Client d = new Client()
            {
                clientid = c.clientid,
                clientemail = c.clientemail,
                clientname = c.clientname,
                clientcontact = c.clientcontact,
                password = c.password,
                username = c.username
            };
            DataAccess.ClientDataAccess().Edit(d);
            return true;
        }
        public static bool AddPackage(BookingModel c)
        {
            /*var config = new MapperConfiguration(cfg=> cfg.CreateMap<Booking, ClientModel>());
            Mapper mapper = new Mapper(config);
            var d = mapper.Map<Booking>(c);*/
            Booking d = new Booking()
            {
                //clientid = c.clientid,
                bookingid = c.bookingid,
                packageid = c.packageid,
                clientid = c.clientid,
            };

            DataAccess.BookingDataAccess().AddPackage(d);
            return true;
        }
        public static bool DeletePackage(int id)
        {
            DataAccess.BookingDataAccess().DeletePackage(id);
            return true;
        }
        //booked packages
        public static BookingModel GetPackage(int uid)
        {
            var u = DataAccess.BookingDataAccess().GetPackage(uid);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Booking, BookingModel>());
            Mapper mapper = new Mapper(config);
            var d = mapper.Map<BookingModel>(u);
            return d;
        }
        public static List<BookingModel> GetPackage()
        {
            var u = DataAccess.BookingDataAccess().GetPackage();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Booking, BookingModel>());
            Mapper mapper = new Mapper(config);
            var d = mapper.Map<List<BookingModel>>(u);
            return d;
        }
    }
}
