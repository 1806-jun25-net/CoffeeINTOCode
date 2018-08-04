using System;
using HappyPets.Data;
using HappyPets.Library.Repository.CRUDs;

namespace HappyPets.Library.Repository
{

    public partial class Repository
    {
        private readonly HappyPetsDBContext _db;
        private readonly CRUDs.RepositoryCRUDs _repo;

        public Repository(CRUDs.RepositoryCRUDs repo, HappyPetsDBContext db)
        {
            _db = db;
            _repo = repo ?? throw new ArgumentException(nameof(repo));

        }
    }
}


