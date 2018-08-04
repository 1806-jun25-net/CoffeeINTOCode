using System;
using System.Collections.Generic;

namespace HappyPets.WebApp.Models
{
    public partial class Pet
    {
        public int PetId { get; set; }
        public int? TypesId { get; set; }
        public decimal? Price { get; set; }
        public int? SizeId { get; set; }

        public PetSize Size { get; set; }
        public PetType Types { get; set; }
    }
}
