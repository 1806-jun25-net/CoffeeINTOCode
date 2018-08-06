using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyPets.WebApp.Models
{
    public class History
    {
        public List<int?> OrderID { get; set; }
        public List<DateTime> Date{get; set;}
        public List<decimal?> Ammount {get; set; }
    }
}

