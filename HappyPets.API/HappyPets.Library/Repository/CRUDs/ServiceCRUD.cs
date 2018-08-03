using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class RepositoryCRUDs
    {
        public IEnumerable<Services> GetServices()
        {
            var services = _db.Services.ToList();
            return services;
        }

        public void EditCart(Services services)
        {

            _db.Update(services);
            SaveChanges();
        }

        public void AddService( string sname, string sdescription, decimal price)
        {
            var service = new Services
            {
                ServiceNames = sname,
                ServiceDescription = sdescription,
                ServicePrice = price
                
            };
            _db.Add(service);
            SaveChanges();

        }

        public void DeletePet(Services services)
        {
            _db.Remove(services);
            SaveChanges();
        }

        public IEnumerable<Employee> GetAllLocationEmployee(int location)
        {
           var Employees = _db
        }
    }
}
