using System;
using HappyPets.Library.Repository.CRUDs;

namespace HappyPets.Library.Repository
{

    public partial class Repository
    {
        private readonly RepositoryCRUDs _repo;

        public Repository(RepositoryCRUDs repo)
        {
            _repo = repo ?? throw new ArgumentException(nameof(repo));

        }
    }
}


