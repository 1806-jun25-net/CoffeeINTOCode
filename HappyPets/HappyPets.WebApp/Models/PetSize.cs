using System;
using System.Collections.Generic;

namespace HappyPets.WebApp.Models
{
    public partial class PetSize
    {
        public PetSize()
        {
            Pet = new HashSet<Pet>();
        }

        public int SizeId { get; set; }
        public string PetSize1 { get; set; }

        public ICollection<Pet> Pet { get; set; }
    }
}
