﻿using System;
using System.Collections.Generic;

namespace HappyPets.WebApp.Models
{
    public partial class Cart2
    {
        public int CartId { get; set; }
        public int? OrderId { get; set; }
        public int? UsersId { get; set; }
        public int? Quantity { get; set; }
        public int? ItemId { get; set; }
        public bool? ItemType { get; set; }
        public bool? Active { get; set; }
        public decimal? ItemTotalCost { get; set; }
        
    }
}
