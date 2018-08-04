using System;
using System.Collections.Generic;

namespace HappyPets.WebApp.Models
{
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<Users>();
        }

        public int TypesId { get; set; }
        public string TypesName { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
