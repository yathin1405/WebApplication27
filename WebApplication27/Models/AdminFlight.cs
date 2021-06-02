using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication27.Data;

namespace WebApplication27.Models
{
    public class AdminFlight
    {
        public enum From
        {
            JHB,
            Durban,
            Capetown,

        }
        public enum To
        {
            JHB,
            Durban,
            Capetown,

        }
        public enum Class
        {
            Economy,
            Business,
            First,

        }

        public enum Passenger
        {
            Adult,
            child,
            infant,
        }

        WebApplication27Context db = new WebApplication27Context();
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PlaneID { get; set; }
        [Display(Name = "From")]
        public From LocationFrom { get; set; }
        [Display(Name = "TO")]
        public To LocationTO { get; set; }

        [Display(Name = "Aeroplane Name")]
        [Required(ErrorMessage = "Aeroplane name required")]
        [MaxLength(30, ErrorMessage = "Maxinum 30 charecters allowed"), MinLength(3, ErrorMessage = "Minimun 3 charecters allowed")]

        public string AeroplaneName { get; set; }

        [Display(Name = "Departure Time")]
        [DataType(DataType.Time)]
        public DateTime DepartureTime { get; set; }

        [Required(ErrorMessage = "Capacity required")]
        [Display(Name = "Seating Capacity")]
        public int SeatingCapacity { get; set; }

        [Required(ErrorMessage = "Price Required")]
        public float Price { get; set; }


    }
}
