using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HappyPets.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HappyPets.WebApp.Controllers
{
    public class OrderController : AServiceController
    {
        // GET: Order
        public OrderController(HttpClient httpClient) : base(httpClient)
        {

        }

        public async Task<ActionResult> ShowCart()
        {
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Order/ShowCart");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();
                
                IEnumerable<Cart> GetCart = JsonConvert.DeserializeObject<IEnumerable<Cart>>(jsonString);
                return View(GetCart);
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }
        }

        
    }
}