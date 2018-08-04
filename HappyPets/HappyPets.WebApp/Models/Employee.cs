using System;
using System.Collections.Generic;

namespace HappyPets.WebApp.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Appointments = new HashSet<Appointments>();
            EmployeeRating = new HashSet<EmployeeRating>();
            Orders = new HashSet<Orders>();
            Users = new HashSet<Users>();
        }

        public int EmployeeId { get; set; }
        public int? LocationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Location Location { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
        public ICollection<EmployeeRating> EmployeeRating { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
