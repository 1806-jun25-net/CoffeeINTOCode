using HappyPets.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HappyPets.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(Currentuser user)
        {
           
            TempData["current_user"] = user.Username;
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        // Controllers for test Design
        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult CatalogServices()
        {
            return View();
        }

        public IActionResult ProductCatalog()
        {
            return View();
        }

        public IActionResult ServicesDetails()
        {
            return View();
        }

        public IActionResult ProductDetails()
        {
            return View();
        }


    }
}
