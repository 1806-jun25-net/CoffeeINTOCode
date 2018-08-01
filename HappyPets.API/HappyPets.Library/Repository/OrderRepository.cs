using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyPets.Library
{

    public partial class Repository
    {

        public IEnumerable<Orders> GetOrderById(int id)
        {


                         
            var order = _db.Orders.Where(g => g.OrderId == id);
            if (order == null)
            {
                return null;
            }

            else
            {
                return order;
            }




        }


        public int? GetActiveCart(int userid)
        {

            var order = _db.Orders.Last();
            var orderId = order.OrderId;
            var activeCart = _db.Cart.Last(g=> g.OrderId == orderId);
            
            return activeCart.OrderId;

        }
        public IEnumerable<Products> GetCurrentProduct(int userorderId)
        {
            List<int?> productId = new List<int?>();
            var products = new List<Products>();
            


            var cart = _db.Cart.Where(g => g.OrderId == userorderId);
            foreach (var item in cart)
            {
               productId.Add(item.ItemId);
            }

            //get products in cart with the product
            foreach (var product in productId)
            {
                 //products = _db.Products.Where(g => g.ProductId == product);
            }
            

            


            return products;

        }

        //public IEnumerable<Services> GetCurrentService(int userorderId)
        //{

        //}

        public decimal GetPricebyProductId(int id)
        {
            //var price = _db.Products
        }
        public decimal GetPricebyServiceId(int id)
        {

        }







    }
}
