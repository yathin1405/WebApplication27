using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebApplication27.Data;

namespace WebApplication27.Models
{
    public class UserFlight : AdminFlight
    {
        WebApplication27Context db = new WebApplication27Context();
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserFlightID { get; set; }
        
        public new int PlaneID { get; set; }
        /*fk*/
        public virtual AdminFlight AdminFlights{ get; set; }


        public int bid { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        [Display(Name = "Class")]
        public Class SeatingClass { get; set; }

        [Display(Name = "Passenger Type")]
        public Passenger PassengerType { get; set; }

        [Display(Name = "Aeroplane")]
        public string Aeroplane { get; set; }
        [Display(Name = "Departure")]
        public string Departure { get; set; }







        public string GetPlane()
        {

            var Aeroplane = (from c in db.AdminFlights
                             where c.PlaneID == PlaneID
                             select c.AeroplaneName).Single();


            return Aeroplane.ToString();


        }

        public string GetDepart()
        {
            var Depart = (from c in db.AdminFlights
                          where c.PlaneID == PlaneID
                          select c.DepartureTime).Single();

            return Depart.ToString();
        }
    }
}