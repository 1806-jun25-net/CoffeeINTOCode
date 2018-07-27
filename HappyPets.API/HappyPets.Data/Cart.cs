using System;
using System.Collections.Generic;

namespace HappyPets.Data
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int? OrderId { get; set; }
        public int? UsersId { get; set; }
        public int? Quantity { get; set; }
        public int? ItemId { get; set; }
        public bool? ItemType { get; set; }
        public bool? Active { get; set; }
        public decimal? ItemTotalCost { get; set; }

        public Orders Order { get; set; }
        public Users Users { get; set; }
    }
}
