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
            var cartOrderId = Repo.GetActiveCartOrderId(userid);
            var cart = Repo.GetCartByOrderId(cartOrderId);
            
            //send cart to the mvc frontend

            return cart;
        }

        public async Task<ActionResult> Choose(IFormCollection viewCollection)
        {
            //get data from form
            var location = viewCollection["selectedLocation"];
            var time = viewCollection["selectedTime"];
            var date = viewCollection["selectedDate"];

            Repo.

        }

      


        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateOrder()
        {
            try
            {



                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}