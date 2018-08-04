using System;
using System.Collections.Generic;

namespace HappyPets.WebApp.Models
{
    public partial class Services
    {
        public int ServiceId { get; set; }
        public string ServiceNames { get; set; }
        public string ServiceDescription { get; set; }
        public decimal? ServicePrice { get; set; }
    }
}
