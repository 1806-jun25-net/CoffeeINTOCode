﻿using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class Repository
    {
        /////////////////////// Get Orders ////////////////////////////////////
        public IEnumerable<Orders> GetOrders()
        {
            var orders = _db.Orders.ToList();
            return orders;
        }

        /////////////////////// ADD Order ////////////////////////////////////
        public void AddOrders(DateTime OrderTime, decimal TotalCost, int location, int employee)
        {


            var orders = new Orders
            {
                LocationId = location,
                EmployeeId = employee,
                OrderTime = OrderTime,
                TotalCost = TotalCost

            };
            _db.Add(orders);
            SaveChanges();
        }


        /////////////////////// Edit Order ////////////////////////////////////
        public void Edit(Orders order)
        {
            //updates the current order 
            _db.Update(order);
            SaveChanges();
        }


    }
}