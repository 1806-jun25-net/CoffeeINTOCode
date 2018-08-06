using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyPets.Data;
using HappyPets.Data.Data;
using HappyPets.Library.Repository;
using HappyPets.WebApp.Models;
using HappyPets.WepApi.Data;
using HappyPets.WepApi.Data.Data;
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

        [HttpPost]
        public void AddProductToCart(AddToCart cart)
        {
            bool isNewCart;
            int? orderid;
            bool itemType = cart.ItemType;
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

        [HttpPost]
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

        public void PlaceOrder(MyOrder order)
        {
            int? orderid = order.OrderId;
            var appointment = Repo.GetApointmentByOrderId(orderid);
            int? emploeyeeid = appointment.EmployeeId;
            int locationid = Repo.GetLocationOfEmployee(emploeyeeid);
            decimal? totalcost = Repo.GetOrderTotal(orderid);
            DateTime ordertime = DateTime.Now;

            //DateTime OrderTime, decimal TotalCost, int location, int employee
            int norderid = int.Parse(orderid.ToString());
            Repo.CreateOrder(ordertime,totalcost,locationid,emploeyeeid,norderid);


            View("Success");

        }

        public OrdersDetailsRating OrderDetailsRating(OrdersDetailsRating order)
        {
            

            int? employeeid = Repo.GetEmployeeOfOrder(order.OrderId);
            var Employee = Repo.GetEmployee(employeeid);
            int? Rating = Repo.GetEmployeeRatingByEmployeeId(employeeid);

            var products = Repo.GetCurrentProduct(order.OrderId);
            var services = Repo.GetCurrentService(order.OrderId);

            OrdersDetailsRating showOrder = new OrdersDetailsRating
            {
                Employee_Firstname = Employee.FirstName,
                Employee_Lastname = Employee.LastName,
                AppointmentDate = order.AppointmentDate,
                OrderId = order.OrderId,
                OrderTotal = order.OrderTotal,
                ProductsItems = products,
                ServicesItems = services,
                Rating = Rating
        
            };


            return showOrder;

        }

        public History OrderHistory(Users user)
        {
           var myuser = Repo.GetUserByUserName(user.UserName);
           var userid = myuser.UsersId;
           var orders = Repo.GetuserOrders(userid);//get orders ids
            List<decimal?> ammount = new List<decimal?>();
            List<DateTime> date = new List<DateTime>();
            

            foreach (var id in orders)
            {
                date.Add(Repo.GetOrderDate(id));
            }

            foreach (var id in orders)
            {
                ammount.Add(Repo.GetOrderTotal(id));
                
            }

            History orderHistory = new History
            {
                OrderID = orders,
                Date = date,
                Ammount = ammount
            };

            return orderHistory;



           


            
            
        }











    }
}