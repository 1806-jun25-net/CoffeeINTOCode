using System;
using System.Collections.Generic;

namespace HappyPets.WebApp.Models
{
    public partial class Location
    {
        public Location()
        {
            Employee = new HashSet<Employee>();
            Orders = new HashSet<Orders>();
            Users = new HashSet<Users>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }

        public ICollection<Employee> Employee { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
