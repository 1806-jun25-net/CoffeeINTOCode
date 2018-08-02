using System;
using System.Collections.Generic;

namespace HappyPets.Data
{
    public partial class Users
    {
        public Users()
        {
            Appointments = new HashSet<Appointments>();
            Cart = new HashSet<Cart>();
        }

        public int UsersId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Passwords { get; set; }
        public string StreetAddress { get; set; }
        public int? LocationId { get; set; }
        public int? EmployeeId { get; set; }
        public int? UserType { get; set; }
        public string UserName { get; set; }

        public Employee Employee { get; set; }
        public Location Location { get; set; }
        public UserType UserTypeNavigation { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
        public ICollection<Cart> Cart { get; set; }
    }
}
