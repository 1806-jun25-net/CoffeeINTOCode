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

        [HttpPost]
        public async Task<ActionResult> GetAllServices(IFormCollection viewCollection) 
        {
            string searchText = viewCollection["selectedSearchInput"];
            string orderBy = viewCollection["selectedOrder"];

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
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }
        }
    }
}