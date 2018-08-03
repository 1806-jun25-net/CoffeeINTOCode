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
        public IEnumerable<Cart> ShowCart()
        {
            //get user current cart
            string username = TempData.Peek("current_user").ToString();
            var user = Repo.GetUserByUserName(username);
            var userid = user.UsersId;
            var cartOrderId = Repo.GetActiveCartOrderId(userid);//fix this - check active column 
            var cart = Repo.GetCartByOrderId(cartOrderId);
            
            //send cart to the mvc frontend

            return cart;
        }

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




        



      
        
    }
}