using System;
using System.Collections.Generic;

namespace HappyPets.Data
{
    public partial class Services
    {
        public int ServiceId { get; set; }
        public string ServiceNames { get; set; }
        public string ServiceDescription { get; set; }
        public decimal? ServicePrice { get; set; }
        public string ImgPath { get; set; }
        public string Size { get; set; }
    }
}
