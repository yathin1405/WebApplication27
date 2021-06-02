using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication27.Models;

namespace WebApplication27.Data
{
    public class WebApplication27Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplication27Context() : base("name=WebApplication27Context")
        {
        }
        public DbSet<AdminTour> AdminTours { get; set; }

        public DbSet<UserTour> UserTours { get; set; }
        public DbSet<UserFlight> UserFlights { get; set; }

        public DbSet<AdminFlight> AdminFlights { get; set; }

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
