﻿using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class RepositoryCRUDs
    {
        /////////////////////// Get Orders ////////////////////////////////////
        public IEnumerable<Orders> GetOrders()
        {
            var orders = _db.Orders.ToList();
            return orders;
        }
        public IEnumerable<Orders> GetOrders(int? id )
        {
            var orders = _db.Orders.Where(g => g.OrderId == id);
            return orders;
        }

        public DateTime GetOrderTime(int? id)
        {
            var order = _db.Orders.First(g => g.OrderId == id);
            return order.OrderTime;
        }


        /////////////////////// ADD Order ////////////////////////////////////
        public void AddOrders(DateTime OrderTime, decimal? TotalCost, int location, int? employee, int orderid)
        {


            var orders = new Orders
            {
                OrderId = orderid,
                LocationId = location,
                EmployeeId = employee,
                OrderTime = OrderTime,
                TotalCost = TotalCost

            };
            _db.Add(orders);
            SaveChanges();
        }


        /////////////////////// Edit Order ////////////////////////////////////
        public void EditOrders(Orders order)
        {
            //updates the current order 
            _db.Update(order);
            SaveChanges();
        }

        public void DeleteOrders(Orders order)
        {
            _db.Remove(order);
            SaveChanges();
        }


    }
}
