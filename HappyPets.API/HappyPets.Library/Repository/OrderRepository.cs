using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyPets.Library.Repository
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
                 products.Add( _db.Products.FirstOrDefault(g => g.ProductId == product));
            }
            


            return products;

        }

        public IEnumerable<Services> GetCurrentService(int userorderId)
        {
            List<int?> serviceid = new List<int?>();
            var services = new List<Services>();



            var cart = _db.Cart.Where(g => g.OrderId == userorderId);
            foreach (var item in cart)
            {
                serviceid.Add(item.ItemId);
            }

            //get products in cart with the product
            foreach (var service in serviceid)
            {
                services.Add(_db.Services.FirstOrDefault(g => g.ServiceId == service));
            }

            return services;
        }

        public decimal? GetPricebyProductId(int id)
        {
            var product = _db.Products.FirstOrDefault(g=> g.ProductId == id );
            var price = product.ProductPrice;
            return price;
        }
        public decimal? GetPricebyServiceId(int id)
        {
            var product = _db.Services.FirstOrDefault(g => g.ServiceId == id);
            var price = product.ServicePrice;
            return price;
        }

        public decimal? GetPriceForService(int serviceid, string petSize)
        {  
            decimal? addS = 5, addM =10, addL =15, servicePrice;
            var service = _db.Services.FirstOrDefault(g => g.ServiceId ==serviceid);
            decimal? price = service.ServicePrice;

            //calculate price of service by pet size
            if (petSize == "S")
            {
                servicePrice = price + addS; 
            }
            if (petSize == "M")
            {
                servicePrice = price + addM;
            }
            else
            {
                servicePrice = price + addL;
            }

            return servicePrice;



        }

        public int? CheckItemAvailability(int id)
        {
            var product = _db.Products.First(g => g.ProductId == id);
            var quantity = product.InventoryQuantity;

            if (quantity > 0)
            {
                return quantity;

            }
            else
            {
                return 0;

            }

        }
        /////////////////////// Create Order id ////////////////////////////////////
        public int? CreateOrderId()
        {
            var orders = _db.Orders.ToList();
            List<int> ordersid = new List<int>();
            foreach (var item in orders)
            {
                ordersid.Add(item.OrderId);
            }

            var max = ordersid.Max();
            max++;

            return max;
        }










    }
}
