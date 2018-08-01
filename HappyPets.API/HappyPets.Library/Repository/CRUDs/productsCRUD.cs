using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class Repository
    {
        public IEnumerable<Products> GetProducts()
        {
            var products = _db.Products.ToList();
            return products;
        }
        
        public void EditCart(Products product)
        { 

            _db.Update(product);
            SaveChanges();
        }

        public void AddProduct( int invetory, string pname, string pdescription, decimal price)
        {
            var product = new Products
            {
                ProductNames = pname,
                ProductDescription = pdescription,
                ProductPrice = price,
                InventoryQuantity = invetory
            };
            _db.Add(product);
            SaveChanges();

    }

        //public IEnumerable<Products> DeleteProduct()
        //{

        //}


    }
}
