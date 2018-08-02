using System;
using System.Collections.Generic;
using System.Linq;
using HappyPets.Data;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class RepositoryCRUDs
    {
        // CRUD operation for Users
        // Create
        public void CreateUser(Users user)
        {
            _db.Add(user);
            SaveChanges();

        }

        public void CreateUser(
            string firstName, 
            string lastName, 
            string email,
            string password, 
            string streetAddress, 
            int locationId,
            int userType,
            int? employeeId)
        {
            var user = new Users
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Passwords = password,
                StreetAddress = streetAddress,
                LocationId = locationId,
                EmployeeId = employeeId,
                UserType = userType,
            };

            _db.Add(user);
            SaveChanges();

        }

        // Read Single
        public Users GetUsersByID(int id)
        {
            var user = _db.Users.Find(id);
            string errMsg = "Not User found with that ID";

            if (user == null)
            {
                throw new ArgumentException(errMsg, nameof(id));
            }

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
            SaveChanges();
        }


        // Delete
        public void DeleteUser(int Id)
        {
            var userToDelete = _db.Users.Find(Id);
            string errMsg = "Not User found with that ID";

            if(userToDelete == null)
            {
                throw new ArgumentException(errMsg, nameof(Id));
            }

            _db.Remove(userToDelete);
            SaveChanges();
        }

        // Others Operations
        public IEnumerable<Users> GetUserByName(string firstname)
        {
            var users = _db.Users.Where(n => n.FirstName == firstname).ToList();
            return users;
        }


        public IEnumerable<Users> GetUserByLastName(string lastName)
        {
            var users = _db.Users.Where(n => n.LastName == lastName).ToList();
            return users;
        }


        public IEnumerable<Users> GetUserByEmail(string email)
        {
            var users = _db.Users.Where(n => n.Email == email).ToList();
            return users;
        }

        public IEnumerable<Users> GetUserByLocation(int id)
        {
            var users = _db.Users.Where(n => n.LocationId == id).ToList();
            return users;
        }

        public IEnumerable<Users> GetUserByUserTypeId(int id)
        {
            var users = _db.Users.Where(n => n.UserType == id).ToList();
            return users;
        }
    }
}
