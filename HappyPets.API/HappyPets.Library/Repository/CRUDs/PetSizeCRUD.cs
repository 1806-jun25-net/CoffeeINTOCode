using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class Repository
    {


        /////////////////////// Get Pet Sizes ////////////////////////////////////
        public IEnumerable<PetSize> GetPetSizes()
        {
            var petSizes = _db.PetSize.ToList();
            return petSizes;
         }
    
        /////////////////////// Add Pet Sizes ////////////////////////////////////
        public void AddPetSize(string size)
        {


            var petSize = new PetSize
            {
                PetSize1 = size

            };
            _db.Add(petSize);
            SaveChanges();
        }


        /////////////////////// Edit Pet Sizes ////////////////////////////////////
        public void EditPetsize(PetSize size)
        {
            //updates the current pet
            _db.Update(size);
            SaveChanges();
        }
        public void DeletePetsize(PetSize size)
        {
            _db.Remove(size);
            SaveChanges();
        }


    }
}
