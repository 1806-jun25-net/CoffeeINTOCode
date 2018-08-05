using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyPets.WebApp.Models
{
    public class AddToCart
    {
        public int EmployeeId { get; set; }
        public int Quantity { get; set; } 
        public string Size { get; set;  }
        public int ItemId { get; set; } 
        public bool ItemType { get; set; }
        public string Username { get; set; }

    }
    
}
