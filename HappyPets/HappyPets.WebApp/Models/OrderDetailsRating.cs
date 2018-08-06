using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyPets.WebApp.Models
{
    public class OrderDetailsRating
    {
        public string Employee_Firstname { get; set; }
        public string Employee_Lastname { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public int? OrderId { get; set; }
        public decimal? OrderTotal { get; set; }
        public IEnumerable<Products> ProductsItems { get; set; }
        public IEnumerable<Services> ServicesItems { get; set; }
        public int? Rating { get; set; }
        public string Username { get; set; }
        //order
    }
}
