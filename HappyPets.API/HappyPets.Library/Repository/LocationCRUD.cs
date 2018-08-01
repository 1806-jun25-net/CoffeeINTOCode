using System;
using System.Collections.Generic;
using System.Linq;
using HappyPets.Data;

namespace HappyPets.Library.Repository
{
    public partial class Repository
    {
        // CRUD operation for Location
        // Create
        public void CreateLocation(Location location)
        {
            _db.Add(location);

        }

        public void CreateLocation(string locationName)
        {
            var location = new Location
            {
                LocationName = locationName
            };

            _db.Add(location);

        }

        // Read Single
        public Location GetLocationByID(int id)
        {
            var location = _db.Location.Find(id);
            string errMsg = "Not Location found with that ID";

            if (location == null)
            {
                throw new ArgumentException(errMsg, nameof(id));
            }

            return location;

        }

        // Read All
        public IEnumerable<Location> GetAllLocation()
        {
            var allLocation = _db.Location.ToList();
            return allLocation;
        }

        // Update
        public void UpdateLocation(Location location)
        {
            _db.Location.Update(location);
        }


        // Delete
        public void DeleteLotion(int Id)
        {
            var location = _db.Location.Find(Id);
            string errMsg = "Not Location found with that ID";

            if (location == null)
            {
                throw new ArgumentException(errMsg, nameof(Id));
            }

            _db.Remove(location);
        }
    }
}
