using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLibrary
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        //Level 1 database: independent to other
        public DbSet<TbUser> TableUser { get; set; } 
        public DbSet<TbBusType> TableBusType { get; set; }
        public DbSet<TbLocation> TableLocation { get; set; }
        public DbSet<TbBusStatus> TableBusStatus { get; set; }
        public DbSet<TbEmpType> TableEmpType { get; set; }
        public DbSet<TbEmpStatus> TableEmpStatus { get; set; }

        //Level 2 database: the CRUD operations are dependend on Level 1 database
        public DbSet<TbBus> TableBus { get; set; }
        public DbSet<TbSeat> TableSeat { get; set; }
        public DbSet<TbEmployee> TableEmployee { get; set; }
        public DbSet<TbRoute> TableRoute { get; set; }
        public DbSet<TbTrip> TableTrip { get; set; }
        public DbSet<TbPrice> TablePrice { get; set; }
        public DbSet<TbReservation> TableReservation { get; set; }
        public DbSet<TbPassenger> TablePassenger { get; set; }
        public DbSet<TbTripAttendant> TableTripAttendant { get; set; }

        //Not Important
        public DbSet<TbUserLog> TableUserLog { get; set; }
    }
}
