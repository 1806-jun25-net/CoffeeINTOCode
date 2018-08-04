using System;
using System.Collections.Generic;

namespace HappyPets.WebApp.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductNames { get; set; }
        public string ProductDescription { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? InventoryQuantity { get; set; }
    }
}
