﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyPets.Data;
using HappyPets.Library.Repository;
using HappyPets.WebApp.Models;
using HappyPets.WepApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HappyPets.WepApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : Controller
    {
        public Repository Repo;

   
        public OrderController(Repository repo)
        {
            Repo = repo;
        }
        // GET: Order
        [Route("api/[controller]/[action]")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Order/Details/5
        [Route("api/[controller]/[action]")]
        public ActionResult Details(int id)
        {
            return View();
        }
       //[Route("api/[controller]/[action]/{username}")]
        [HttpPost]
        public IEnumerable<CartList> ShowCart(Users users)
        {

            string username = users.UserName;
            IEnumerable<Cart2> cart;
            List<CartList> myCart = new List<CartList>();

           

            int? cartOrderId;
            bool newCart;
 
            var user = Repo.GetUserByUserName(username);
            var userid = user.UsersId;
            (cartOrderId, newCart) = Repo.GetActiveCartOrderId(userid);


            if (newCart == false)
            {

                cart = Repo.GetCartByOrderId(cartOrderId);

                foreach (var item in cart)
                {
                    var name = GetItemName(item.ItemId, item.ItemType);
                    var  price = GetItemCost(item.ItemId, item.ItemType);

                    myCart.Add(new CartList()
                    {
                        itemName = name,
                        itemPrice = decimal.Parse(price.ToString()),
                        itemType = item.ItemType,
                        quantity = item.Quantity
                
                    });

                }

                IEnumerable<CartList> cartList = myCart.Select(x => new CartList
                {
                    itemType = x.itemType,
                    itemName = x.itemName,
                    itemPrice = x.itemPrice,
                    quantity =x.quantity
                 
                });

                return cartList;
            }
           else// if it is new order then create empty cart
            {
                IEnumerable<CartList> empty = null;
                return empty;
            }

            //send cart to the mvc frontend
          
        }
       // [Route("api/[controller]/[action]")]
        public decimal? GetItemCost( int? itemId, bool? itemType)
        {
            decimal? price =0;
           if (itemType == true)
            {
                var item = Repo.GetServiceById(itemId);
                item.ServicePrice = Repo.GetPriceForService(item.ServiceId, item.Size);
                price = item.ServicePrice;
              
            }
           else if (itemType == false)
            {
                var item =Repo.GetProductById(itemId);

                price = item.ProductPrice;
            }
            return price;
            
        }
        //[Route("api/[controller]/[action]")]
        public string GetItemName( int? itemId, bool? itemType)
        {
           
                string itemName = " ";
                if (itemType == true)//if service
                {
                    var service = Repo.GetServiceById(itemId);
                    itemName = service.ServiceNames;

                }
                else if (itemType == false)//if product
                {
                    var item = Repo.GetProductById(itemId);

                    itemName = item.ProductNames;
                }
                return itemName;
            
        }

        [HttpGet]
        //[Route("api/[controller]/[action]")]
        public IEnumerable<Location> OptionsLocation()//options in mvc
        {
            var locations = Repo.GetLocations();

            return locations;
        }
      // [Route("api/[controller]/[action]")]
      [HttpPost]
        public  IEnumerable<Employee> Choose( Choosen choosen)
        {
            var date = choosen.Date;
            var time = choosen.Time;
            var location = choosen.LocationId;

            var employees = Repo.GetAvailableEmployees(date, time, location);

            return employees;
        }

        public void AddProductToCart(AddToCart cart)
        {
            bool isNewCart;
            int? orderid;
            bool itemType = false;
            var username = cart.Username;
            var user = Repo.GetUserByUserName(username);
            var userid = user.UsersId;
            (orderid, isNewCart) = Repo.GetActiveCartOrderId(userid);
            decimal? itemcost = GetItemCost(cart.ItemId, itemType);
            if(isNewCart == true)
            {
                orderid = Repo.CreateOrderId();
            }

            
            Repo.CreateCart(orderid, userid,cart.Quantity,cart.ItemId,itemType,true,itemcost);


        }
        public void AddServiceToCart(AddToCart add)
        {
            bool isNewCart;
            int? orderid;
            bool itemType = true;
            var username = add.Username;
            var user = Repo.GetUserByUserName(username);
            var userid = user.UsersId;
            (orderid, isNewCart) = Repo.GetActiveCartOrderId(userid);
            decimal? itemcost = GetItemCost(add.ItemId, itemType);
            if (isNewCart == true)
            {
                orderid = Repo.CreateOrderId();
            }



            Repo.CreateCart(orderid, userid, add.Quantity, add.ItemId, itemType, true, itemcost);
        }

        // [Route("api/[controller]/[action]")]
        public Services GetServiceDetails( ItemDetails id)
        {
            var itemId = id.ItemId;

            var service = Repo.GetServiceById(itemId);
            return service;
;        }
       // [Route("api/[controller]/[action]")]
        public Products GetProductDetails(ItemDetails id)
        {
            var itemId = id.ItemId;
            var product = Repo.GetProductById(itemId);
            return product;
            
        }
        [HttpPost]
        public OrderDetails Checkout(AddToCart details)
        {
            //details :employeeid and user stored
            int? orderid;
            bool newCart;
            var employeeId = details.EmployeeId;
            var employee = Repo.GetEmployee(employeeId);
            var username = details.Username;
            var user = Repo.GetUserByUserName(username);
            int? userid = user.UsersId;
            (orderid, newCart) = Repo.GetActiveCartOrderId(userid);
            var appointment = Repo.GetApointmentByOrderId(orderid);
            DateTime? appointmentDate = appointment.AppointmentDate;
            var products = Repo.GetCurrentProduct(orderid);
            var services = Repo.GetCurrentService(orderid);
            var ordertotal = Repo.GetOrderTotal(orderid);


            OrderDetails order = new OrderDetails
            {
                Employee_Firstname = employee.FirstName,
                Employee_Lastname = employee.LastName,
                appointmentDate = appointmentDate,
                OrderId = orderid,
                ProductsItems = products,
                ServicesItems = services,
                OrderTotal = ordertotal
            };

            //orderId, total, orderdate, appointment, item price, item name
            return order; 

    }










    }
}