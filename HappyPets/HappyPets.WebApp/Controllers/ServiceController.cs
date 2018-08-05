using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HappyPets.WebApp.Models;
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


        /// <summary>
        /// Most Expensive Services firsts
        /// </summary>
        /// <returns></returns>

        public async Task<ActionResult> GetAllServicesByMostExpensive()
        {

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Services/GetAllServicesByMostExpensive");

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
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }
        }

    }
}