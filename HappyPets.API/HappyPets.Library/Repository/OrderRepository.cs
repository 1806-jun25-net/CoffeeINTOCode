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
        public IEnumerable<Cart2> GetCartByOrderId(int? orderid)
        {
            var allCarts = _repo.GetCart();
            var myCart = new List<Cart2>();

            foreach (var cart in allCarts)
            {
                if (cart.OrderId == orderid)
                {
                    myCart.Add(cart);
                }
            }

            return myCart;

        }

        //public IEnumerable<Cart2> GetCartByOrderId(int? orderid)
        //{
        //    var allCarts = _repo.GetCart();
        //    var myCart = new List<Cart>();

        //    foreach (var cart in allCarts)
        //    {
        //        if (cart.OrderId == orderid)
        //        {
        //            myCart.Add(cart);
        //        }
        //    }

        //    IEnumerable<Cart2> thecart = myCart.Select(x => new Cart2
        //    {
        //        Active = x.Active,
        //        CartId = x.CartId,
        //        ItemId = x.ItemId,
        //        ItemTotalCost = x.ItemTotalCost,
        //        ItemType = x.ItemType,
        //        OrderId = x.OrderId,
        //        Quantity = x.Quantity,
        //        UsersId = x.UsersId
        //    });





        //    return thecart;

        //}
        public (int?,bool) GetActiveCartOrderId(int userid)
        {

            var order = _db.Orders.Last();
            var orderId = order.OrderId;
            var lastCart = _db.Cart.Last(g=> g.OrderId == orderId);
            var isActive = lastCart.Active;
            int? id=0;

            bool newcart = false;
            if (isActive == true)
            {
                id = lastCart.OrderId;
            }
            else if (isActive == false)
            {
                //id = CreateOrderId();
                id = null;
                newcart = true;


            }



            return (id, newcart); 

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
