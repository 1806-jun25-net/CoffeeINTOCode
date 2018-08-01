﻿using System;
using System.Collections.Generic;
using System.Linq;
using HappyPets.Data;
namespace HappyPets.Library.Repository.CRUDs
{
    public partial class RepositoryCRUDs
    {
        // CRUD operation for Employee Rating

        // Create
        public void CreateEmployeeRating(EmployeeRating employeeRating)
        {
            _db.Add(employeeRating);
            SaveChanges();
        }

        public void CreateEmployeeRating(int employeeId, int rating)
        {
            var  employeeRating = new EmployeeRating
            {
                EmployeeId = employeeId,
                Rating = rating
            };
            _db.Add(employeeRating);
            SaveChanges();
        }

        // Read Single
        public EmployeeRating GetUserEmployeeRatingById(int id)
        {
            var employeeRating = _db.EmployeeRating.Find(id);
            string errMsg = "Not Employee Rating found with that Id";

            if (employeeRating == null)
            {
                throw new ArgumentException(errMsg, nameof(id));
            }
            return employeeRating;
        }

        // Read All
        public IEnumerable<EmployeeRating> GetAllEmployeeRating()
        {
            var employeeRatings = _db.EmployeeRating.ToList();
            return employeeRatings;
        }


        // Update
        public void UpdateEmployeeRating(EmployeeRating employeeRating)
        {
            _db.EmployeeRating.Update(employeeRating);
            SaveChanges();
        }

        // Delete
        public void DeleteEmployeeRating(int Id)
        {
            var employeeRating = _db.EmployeeRating.Find(Id);
            string errMsg = "Not Employee Rating found with that ID";

            if (employeeRating == null)
            {
                throw new ArgumentException(errMsg, nameof(Id));
            }

            _db.Remove(employeeRating);
            SaveChanges();
        }
    }
}
