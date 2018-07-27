using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyPets.Library
{
    public class URepository
    {
        private readonly HappyPetsDBContext _db;

        public URepository(HappyPetsDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public IEnumerable<Users> GetUsertable()
        {
            List<Users> user = _db.Users.ToList();
            return user;

        }

    }
}
