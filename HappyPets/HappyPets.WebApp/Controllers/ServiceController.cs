using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HappyPets.Data;
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

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Service/GetAllProducts");

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
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Service/GetAllServices");

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
    }
}