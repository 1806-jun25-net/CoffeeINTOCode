using System;
using System.Collections.Generic;

namespace HappyPets.Data
{
    public partial class PetType
    {
        public PetType()
        {
            Pet = new HashSet<Pet>();
        }

        public int TypesId { get; set; }
        public string TypesName { get; set; }

        public ICollection<Pet> Pet { get; set; }
    }
}
