﻿using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class Repository
    {

        private readonly HappyPetsDBContext _db;

        public Repository(HappyPetsDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public IEnumerable<Cart> GetCart()
       {
            var cart = _db.Cart.ToList();
            return cart;
        }
       public void EditCart(Cart cart)
       {
            
            _db.Update(cart);
            SaveChanges();
        }

        public void  AddCart(int orderid, int userid, int quantity, int itemid, bool itemType, bool active, decimal itemCost)
        {
                var cart = new Cart
                {
                   OrderId = orderid,
                   UsersId = userid,
                   Quantity = quantity,
                   ItemId =  itemid,
                   Active = active,
                   ItemTotalCost = itemCost
                };
                _db.Add(cart);
                SaveChanges();

            

    }

        //public IEnumerable<Cart> DeleteCart()
        //{

        //}
        public void SaveChanges()
        {
            _db.SaveChanges();
        }




    }
}
