using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HappyPets.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HappyPets.WebApp.Controllers
{
    public class MyGroomingController : AServiceController
    {

        public MyGroomingController(HttpClient httpClient) : base(httpClient) {  }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        // GET: /<controller>/
        public async Task<IActionResult> OrderDetailsRating(int orderid)
        {
            string username = TempData.Peek("current_user").ToString();
            OrderDetailsRating myorder = new OrderDetailsRating { Username = username, OrderId = orderid };
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Post, "api/Order/OrderDetailsRating", myorder);


            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();


                OrderDetailsRating order = JsonConvert.DeserializeObject<OrderDetailsRating>(jsonString);


                return View(order);



            }
            catch (AggregateException ex)
            {
                return View("Error");
            }

            
        }
    }
}
