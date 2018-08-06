using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HappyPets.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HappyPets.WebApp.Controllers
{
    public class ServiceController : AServiceController
    {
        public ServiceController(HttpClient httpClient) : base(httpClient)
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetAllProducts()
        {

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Services/GetAllProducts");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

                IEnumerable<Products> AllProducts = JsonConvert.DeserializeObject<IEnumerable<Products>>(jsonString);
                return View(AllProducts);
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }
        }
        /// <summary>
        /// Most Expensive Products firsts
        /// </summary>
        /// <returns></returns>

        public async Task<ActionResult> GetAllProductsByMostExpensive()
        {

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Services/GetAllProductsByMostExpensive");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

                IEnumerable<Products> AllProducts = JsonConvert.DeserializeObject<IEnumerable<Products>>(jsonString);
                return RedirectToAction("GetAllProducts", AllProducts);
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public async Task<ActionResult> GetAllProductsByCheaper()
        {

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Services/GetAllProductsByCheaper");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

                IEnumerable<Products> AllProducts = JsonConvert.DeserializeObject<IEnumerable<Products>>(jsonString);
                return RedirectToAction("GetAllProducts", AllProducts);
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }
        }





        public async Task<ActionResult> GetAllServices()
        {
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Services/GetAllServices");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

                IEnumerable<Services> AllServices = JsonConvert.DeserializeObject<IEnumerable<Services>>(jsonString);
                return View(AllServices);
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }
        }

<<<<<<< HEAD
        [HttpPost]
        public async Task<ActionResult> GetAllServices(IFormCollection viewCollection) 
        {
            string searchText = viewCollection["selectedSearchInput"];
            string orderBy = viewCollection["selectedOrder"];

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Services/GetAllServices");
=======

        /// <summary>
        /// Most Expensive Services firsts
        /// </summary>
        /// <returns></returns>

        public async Task<ActionResult> GetAllServicesByMostExpensive()
        {

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Services/GetAllServicesByMostExpensive");
>>>>>>> c9dcd9694330a88f05165514984b5fbd15371a44

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

<<<<<<< HEAD
                IEnumerable<Services> AllServices = JsonConvert.DeserializeObject<IEnumerable<Services>>(jsonString);

                var searchQuery = from service in AllServices select service;

                if(!String.IsNullOrEmpty(searchText))
                {
                    searchQuery = searchQuery.Where(s => s.ServiceNames.Contains(searchText));
                }

                if(!String.IsNullOrEmpty(orderBy))
                {
                    switch(orderBy)
                    {
                        case "LOW":
                            searchQuery = searchQuery.OrderBy(s => s.ServicePrice);
                            break;

                        case "HIGH":
                            searchQuery = searchQuery.OrderByDescending(s => s.ServicePrice);
                            break;

                        default:
                            searchQuery = searchQuery.OrderBy(s => s.ServiceNames);
                            break;
                    }
                }

                return View(searchQuery);
=======
                IEnumerable<Products> AllServices = JsonConvert.DeserializeObject<IEnumerable<Products>>(jsonString);
                return RedirectToAction("GetAllServices", AllServices);
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }
        }



        /// <summary>
        /// Cheaper services first
        /// </summary>
        /// <returns></returns>

        public async Task<ActionResult> GetAllServicesByCheaper()
        {

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Services/GetAllServicesByCheaper");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

                IEnumerable<Products> AllServices = JsonConvert.DeserializeObject<IEnumerable<Products>>(jsonString);
                return RedirectToAction("GetAllServices", AllServices);
>>>>>>> c9dcd9694330a88f05165514984b5fbd15371a44
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }
        }
<<<<<<< HEAD
=======

>>>>>>> c9dcd9694330a88f05165514984b5fbd15371a44
    }
}