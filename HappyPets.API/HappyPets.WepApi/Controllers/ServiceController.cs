using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyPets.Data;
using HappyPets.Library.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HappyPets.WepApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {

       
        public Repository Repo { get; set; }


        public ServicesController(Repository repo)
        {
            //_context = context;
            Repo = repo;
        }
        

        [HttpGet]
        //[Authorize]
        public IEnumerable<Services> GetAllServices()
        {
            var services = Repo.GetAllServices();
            return services;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            var products = Repo.GetAllProducts();
            return products;
        }

        // Products Ordered by Most Expensive 
        [HttpGet]
        public IEnumerable<Products> GetAllProductsByMostExpensive()
        {
            var products = Repo.GetProductsByMostExpensive();
            return products;
        }

        // Products Ordered by Cheapest 
        [HttpGet]
        public IEnumerable<Products> GetAllProductsByCheaper()
        {
            var products = Repo.GetProductsByCheapest();
            return products;
        }


        // Services Ordered by Most Expensive 
        [HttpGet]
        public IEnumerable<Services> GetAllServicesByMostExpensive()
        {
            var services = Repo.GetServicesByMostExpensive();
            return services;
        }

        // Services Ordered by Cheapest 
        [HttpGet]
        public IEnumerable<Services> GetAllServicesByCheaper()
        {
            var services = Repo.GetServicesByCheapest();
            return services;
        }



        //[HttpPost]
        ////[Authorize]
        //public IEnumerable<Services> Addservices()
        //{
        //    var services = Repo.AddServices();
        //    return services;
        //}


    }
}