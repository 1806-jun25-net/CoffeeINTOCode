using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyPets.WebApp.Models
{
    public partial class Choosen
    {
        public int LocationId { get; set; }
        public DateTime Date { get; set;  }
        public bool Time { get; set; }

    }
}
