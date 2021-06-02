using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication27.Models
{
    public class BookingContext:DbContext
    {
        //internal object reservations;
        //internal object BookingRoom;
        //internal readonly IEnumerable<object> rooms;

        public BookingContext() : base("BookingDb") { }



        public DbSet<AdminTour> AdminTours { get; set; }

        public DbSet<UserTour> UserTours { get; set; }
        public DbSet<AdminFlight> AdminFlights { get; set; }

        public DbSet<UserFlight> UserFlights { get; set; }
        //public DbSet<HotelBooking> HotelBookings { get; set; }
        //public object Locations { get; internal set; }
        //public object Hotels { get; internal set; }
        //public object Rooms { get; internal set; }
        //public object Users { get; internal set; }
        //public object Bookings { get; internal set; }

        //internal object GetAllBooking()
        //{
        //    throw new NotImplementedException();
        //}

        //internal object GetAllUsers()
        //{
        //    throw new NotImplementedException();
        //}

        //internal object GetAllReservation()
        //{
        //    throw new NotImplementedException();
        //}

        //internal object GetAllRooms()
        //{
        //    throw new NotImplementedException();
        //}

        //internal object GetAllHostles()
        //{
        //    throw new NotImplementedException();
        //}

        //internal object GetAllContries()
        //{
        //    throw new NotImplementedException();
        //}

        public static BookingContext Create()
        {
            return new BookingContext();
        }

        protected override void OnModelCreating(DbModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<AdminTour>().HasKey<int>(x => x.Tour_Num);

            ModelBuilder.Entity<UserTour>().HasKey<int>(x => x.UserID);
            ModelBuilder.Entity<AdminFlight>().HasKey<int>(x => x.PlaneID);

            ModelBuilder.Entity<UserFlight>().HasKey<int>(x => x.UserFlightID);


        }
    }
}