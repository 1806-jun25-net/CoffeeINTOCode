using System;
using System.Collections.Generic;
using System.Text;

namespace HappyPets.Data.Data
{
    public partial class OrdersDetailsRating
    {
        public string Employee_Firstname { get; set; }
        public string Employee_Lastname { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public int? OrderId { get; set; }
        public decimal? OrderTotal { get; set; }
        public IEnumerable<Products> ProductsItems { get; set; }
        public IEnumerable<Services> ServicesItems { get; set; }
        public int? Rating { get; set;  }
        public string Username { get; set; }
        public List<int?> OrderIDList { get; set; }
        public List<DateTime?> DateList { get; set; }
        public List<decimal?> AmmountList { get; set; }

    }
}
