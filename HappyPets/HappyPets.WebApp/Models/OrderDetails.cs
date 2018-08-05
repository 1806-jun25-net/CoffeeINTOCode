using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyPets.WebApp.Models
{
    public class OrderDetails
    {
        public string Employee_Firstname { get; set; }
        public string Employee_Lastname { get; set; }
        public DateTime? appointmentDate { get; set; }
        public int? OrderId { get; set; }
        public decimal? OrderTotal { get; set; }
        public IEnumerable<Products> ProductsItems { get; set; }
        public IEnumerable<Services> ServicesItems { get; set; }

    }
}
