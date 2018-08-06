using HappyPets.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HappyPets.Library.Repository
{
    public partial class Repository
    {

        /////////////////////// Get Product by Name ////////////////////////////////////
        public IEnumerable<Products> GetProductByName(string findProduct)
        {

            var product = _db.Products.Where(g => g.ProductNames == findProduct);
            if (product == null)
            {
                return null; 
            }

            else
            {
                return product;
            }


        }


        /////////////////////// Get Service by Name ////////////////////////////////////
        public IEnumerable<Services> GetServiceByName(string findService)
        {

            var service = _db.Services.Where(g => g.ServiceNames == findService);
            if (service == null)
            {
                return null;
            }

            else
            {
                return service;
            }




        }
        public Services GetServiceById(int? id)
        {

            var service = _db.Services.FirstOrDefault(g => g.ServiceId == id);
            if (service == null)
            {
                return null;
            }

            else
            {
                return service;
            }




        }
        public Products GetProductById(int? id)
        {

            var Product = _db.Products.First(g => g.ProductId == id);
            if (Product == null)
            {
                return null;
            }

            else
            {
                return Product;
            }




        }



        public IEnumerable<Products> GetAvailableItems()//available products
        {
            var items = _db.Products.Where(g => g.InventoryQuantity > 0);

            if (items == null)
            {
                return null;
            }
            else
            {
                return items;
            }

        }

        public decimal? GetRevenue()
        {
            var revenue = _db.Orders.Sum(x => x.TotalCost);
            return revenue;
        }

        public IEnumerable<Services> GetAllServices()
        {
            var services = _repo.GetServices();
            return services;
        }

        //public IEnumerable<Services> AddServices()
        //{
        //    var services = _repo.AddService();
        //    return services;
        //}

    }
}
