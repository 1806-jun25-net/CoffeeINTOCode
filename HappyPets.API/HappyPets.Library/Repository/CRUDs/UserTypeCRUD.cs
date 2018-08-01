using System;
using System.Collections.Generic;
using System.Linq;
using HappyPets.Data;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class Repository
    {
        // CRUD operation for User Type

        // Create
        public void CreateUserType(UserType userType)
        {
            _db.Add(userType);
        }

        public void CreateUserType( string typeName)
        {
            var userType = new UserType
            {
                TypesName = typeName
            };
            _db.Add(userType);
        }

        // Read Single
        public UserType GetUserTypeByID(int id)
        {
            var userType = _db.UserType.Find(id);
            string errMsg = "Not User Type found with that Id";

            if(userType == null)
            {
                throw new ArgumentException(errMsg, nameof(id));
            }
            return userType;
        }

        // Read All
        public IEnumerable<UserType> GetAllUserType()
        {
            var userTypes = _db.UserType.ToList();
            return userTypes;
        }


        // Update
        public void UpdateUserType(UserType userType)
        {
            _db.UserType.Update(userType);
        }

        // Delete
        public void DeleteUserType(int Id)
        {
            var userType = _db.UserType.Find(Id);
            string errMsg = "Not User Type found with that ID";

            if (userType == null)
            {
                throw new ArgumentException(errMsg, nameof(Id));
            }

            _db.Remove(userType);
        }
    }
}
