using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class RepositoryCRUDs
    {

        public IEnumerable<Cart2> GetCart()
        {
            var cart = _db.Cart.ToList();

            IEnumerable<Cart2> mycart = cart.Select(x => new Cart2
            {
                Active = x.Active,
                CartId = x.CartId,
                ItemId = x.ItemId,
                ItemTotalCost = x.ItemTotalCost,
                ItemType = x.ItemType,
                OrderId = x.OrderId,
                Quantity = x.OrderId,
                UsersId = x.UsersId

            });

            return mycart;
        }
        public void EditCart(int orderid)
        {

            List<Cart> result = (from p in _db.Cart
                           where p.OrderId == orderid
                           select p).ToList();

            foreach (var item in result)
            {

                item.Active = false;
            }

         
            SaveChanges();
        }

        public void AddCart(int? orderid, int userid, int quantity, int itemid, bool itemType, bool active, decimal? itemCost)
        {
            var cart = new Cart
            {
                OrderId = orderid,
                UsersId = userid,
                Quantity = quantity,
                ItemId = itemid,
                ItemType = itemType,
                Active = active,
                ItemTotalCost = itemCost
            };
            _db.Add(cart);
            SaveChanges();



        }

        public void DeleteCart(Cart cart)
        {
            _db.Remove(cart);
            SaveChanges();
        }




    }
}
