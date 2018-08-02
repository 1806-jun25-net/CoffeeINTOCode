using System;
using System.Collections.Generic;

namespace HappyPets.Data
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
