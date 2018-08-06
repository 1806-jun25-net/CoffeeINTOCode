using System;
using System.Collections.Generic;

namespace HappyPets.WepApi.Data.Data
{
    public class History
    {
        public List<int?> OrderID { get; set; }
        public List<DateTime> Date { get; set; }
        public List<decimal?> Ammount { get; set; }
    }
}