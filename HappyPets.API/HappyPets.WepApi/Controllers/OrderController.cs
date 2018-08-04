using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyPets.Data;
using HappyPets.Library.Repository;
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
        public ActionResult Index()
        {
            return View();
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Cart2> ShowCart()
        {
            IEnumerable<Cart2> cart;
            int? cartOrderId;
            bool newCart;
            //get user current cart

            //string username = TempData.Peek("current_user").ToString();
            string username = "Kevin";
            var user = Repo.GetUserByUserName(username);
            var userid = user.UsersId;
            (cartOrderId, newCart) = Repo.GetActiveCartOrderId(userid);//fix this - check active column 


            if (newCart == true)// if it is new order then create empty cart
            {
                cart = null;
                return cart;
            }
            else
            {
                //get cart
                cart = Repo.GetCartByOrderId(cartOrderId);
            }


           
            
            //send cart to the mvc frontend
            return cart;
        }
        public decimal? GetItemCost([FromBody] int itemId, bool? itemType, int cartId )
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
        public string GetItemName([FromBody] int itemId, bool? itemType)
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
        public IEnumerable<Location> OptionsLocation()
        {
            var locations = Repo.GetLocations();

            return locations;
        }
        
        public  IEnumerable<Employee> Choose([FromBody] int location, bool time, DateTime date)
        {
            //get data from form

            var employees = Repo.GetAvailableEmployees(date, time, location);

            return employees;
        }

        public Services GetServiceDetails([FromBody] int itemid)
        {

            var service = Repo.GetServiceById(itemid);
            return service;
;        }

        public Products GetProductDetails([FromBody] int itemid)
        {

            var product = Repo.GetProductById(itemid);
            return product;
            
        }










    }
}