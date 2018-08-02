using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class RepositoryCRUDs
    {
        private readonly HappyPetsDBContext _db;

        public RepositoryCRUDs(HappyPetsDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));

        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

    }
}
