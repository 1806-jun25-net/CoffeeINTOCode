using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class Repository
    {
        private readonly HappyPetsDBContext _db;

        public Repository(HappyPetsDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));

        }
    }
}
