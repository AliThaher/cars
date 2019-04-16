using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cars.Models
{
    public class Reservation
    {
        [Required]
        public int id { get; set; }
        [Required]

        public string name_car { get; set; }
        [Required]
        public string car_number { get; set; }
        [Required]
        public string Type_car { get; set; }
          
        
        public DateTime Release_Date { get; set; }
    }
}