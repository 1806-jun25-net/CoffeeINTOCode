﻿using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class RepositoryCRUDs
    {
        /////////////////////// Get Pets ////////////////////////////////////
        public IEnumerable<Pet> GetPets()
        {
            var pets = _db.Pet.ToList();
            return pets;
        }


        /////////////////////// Add Pet ////////////////////////////////////
        public void AddPets(int size, int type, decimal Price)
        {


            var pets = new Pet
            {
                SizeId = size,
                TypesId = type,
                Price = Price

            };
            _db.Add(pets);
            SaveChanges();
        }


        /////////////////////// Edit Pet ////////////////////////////////////
        public void EditPet(Pet pet)
        {
            //updates the current pet
            _db.Update(pet);
            SaveChanges();
        }

        public void DeletePet(Pet pet)
        {
            _db.Remove(pet);
            SaveChanges();
        }


    }
}
