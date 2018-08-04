using System;
using System.Collections.Generic;

namespace HappyPets.WebApp.Models
{
    public partial class Orders
    {
        public Orders()
        {
            Appointments = new HashSet<Appointments>();
            Cart = new HashSet<Cart>();
        }

        public int OrderId { get; set; }
        public int LocationId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? OrderTime { get; set; }
        public decimal? TotalCost { get; set; }

        public Employee Employee { get; set; }
        public Location Location { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
        public ICollection<Cart> Cart { get; set; }
    }
}
