using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cars.Models
{
    public class Customer
    {
        [Required]
        public int id { get; set; }
        [Required]
        
        public string Customer_name { get; set; }
        [Required]
        public int phone { get; set; }
        [Required]
        public string Type_car { get; set; }
       

    }
}