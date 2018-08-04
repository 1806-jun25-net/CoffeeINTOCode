using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HappyPets.Data;
using HappyPets.WebApp.Models;
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
                
                IEnumerable<Cart> Cart = JsonConvert.DeserializeObject<IEnumerable<Cart>>(jsonString);

                List<CartList> cartList = null;


                foreach (var item in Cart)
                {
                   
                    foreach(var c in cartList)
                    {
                        c.itemType = item.ItemType;
                        var itemCost = GetItemCostAsync(item.ItemId, item.ItemType,item.CartId);
                        c.itemPrice = itemCost;
                            
                    }
                   
                }
              


                //if cart is null => no item added yet
                return View(Cart);
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }
        }

        private async Task<decimal> GetItemCostAsync(int? itemId, bool? itemType, int cartId)
        {
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Order/GetItemCost/{itemId}/{itemType}/{cartId}");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

                IEnumerable<Cart> Cart = JsonConvert.DeserializeObject<IEnumerable<Cart>>(jsonString);

               


                //if cart is null => no item added yet
                return View(Cart);
            }
            

       }

        public async Task<ActionResult> Options ()//show options to user: locations, date, time
        {
            

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Order/OptionsLocation");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

                IEnumerable<Location> Locations= JsonConvert.DeserializeObject<IEnumerable<Location>>(jsonString);


                return View(Locations); //send options to view: choose location, date, time 


            }
            catch (AggregateException ex)
            {
                return View("Error");
            }

          

        }

        public async Task<ActionResult> Choosen(IFormCollection viewCollection)
        {
            //receive selected options from view, selected location, time and date
            int location = int.Parse(viewCollection["selectedLocation"]);
            bool time = bool.Parse(viewCollection["selectedTime"]);
            DateTime date = DateTime.Parse(viewCollection["selectedDate"]);

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Order/Choose/{location}/{time}/{date}");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

                IEnumerable<Employee> employees = JsonConvert.DeserializeObject<IEnumerable<Employee>>(jsonString);

                return View(employees); //send available employees to view

            }
            catch (AggregateException ex)
            {
                return View("Error");
            }


        }

        //public ActionResult SelectEmployee(IFormCollection viewCollection)
        //{
        //    var selectedEmployeeid = int.Parse(viewCollection["selectedEmployee"]);


        //    HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Order/SelectEmployee/{selectedEmployeeid}");


        //    RedirectToAction("PlaceOrder", "Order", );


        //}

        //public ActionResult PlaceOrder()
        //{

        //}






    }
}