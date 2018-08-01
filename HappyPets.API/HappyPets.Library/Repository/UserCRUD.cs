using System;
using System.Collections.Generic;
using System.Linq;
using HappyPets.Data;

namespace HappyPets.Library.Repository
{
    public partial class Repository
    {
        // CRUD operation for Users
        // Create
        public void CreateUser(Users user)
        {
            _db.Add(user);
            
        }

        public void CreateUser(
            string firstName, 
            string lastName, 
            string email,
            string password, 
            string streetAddress, 
            int locationId)
        {
            var user = new Users
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Passwords = password,
                StreetAddress = streetAddress,
                LocationId = locationId
            };

            _db.Add(user);
            
        }

        // Read Single
        public Users GetUsersByID(int id)
        {
            var user = _db.Users.Find(id);
            return user;

        }

        // Read All
        public IEnumerable<Users> GetAllUser()
        {
            var alluser = _db.Users.ToList();
            return alluser;
        }

        // Update
        public void UpdateUser(Users user) 
        {
            _db.Users.Update(user);
        }


        // Delete
        public void DeleteUser(int Id)
        {
            var userToDelete = _db.Users.Find(Id);
            string errMsg = "Not User found with thad ID";

            if(userToDelete == null)
            {
                throw new ArgumentException(errMsg, nameof(Id));
            }

            _db.Remove(userToDelete);
        }
    }
}
