using HappyPets.Data;
using System.Collections.Generic;

namespace HappyPets.Library.Repository
{

    public partial class Repository
    {
        // Users
        public Users GetUser(int id)
        {
            var user = _repo.GetUsersByID(id);
            return user;
        }

        public IEnumerable<Users> GetUsers(string value, int option = 0)
        {
            IEnumerable<Users> user;

            switch(option)
            {
                case 1:
                    user = _repo.GetUserByEmail(value);
                    break;

                case 2:
                    user = _repo.GetUserByLastName(value);
                    break;

                default:
                    user = _repo.GetUserByName(value);
                    break;
            }

            return user;
        }

        public IEnumerable<Users> GetUsers(int locationId)
        {
            var user = _repo.GetUserByLocation(locationId);
            return user;
        }

        public IEnumerable<Users> GetAllUsers()
        {
            var user = _repo.GetAllUser();
            return user;
        }

        public void EditUser(Users users)
        {
            _repo.UpdateUser(users);
        }

        public void CreateNewUser(Users user)
        {
            _repo.CreateUser(user);
        }

        public void CreateNewUser(
            string firstName,
            string lastName,
            string email,
            string password,
            string streetAddress,
            int locationId)
        {
            _repo.CreateUser(
                firstName,
                lastName,
                email,
                password,
                streetAddress,
                locationId
            );
        }






        // Employee
    }
}

 
