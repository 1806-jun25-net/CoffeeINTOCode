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
    public class OrderController : AServiceController
    {
        // GET: Order
        public OrderController(HttpClient httpClient) : base(httpClient)
        {

        }
        //[HttpGet("username")]
        public async Task<ActionResult> ShowCart()
        {
            string username = TempData["current_user"].ToString();
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Order/ShowCart/{username}");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

                IEnumerable<Cart> Cart = JsonConvert.DeserializeObject<IEnumerable<Cart>>(jsonString);//null if cart is empty
                if (Cart == null)
                {
                    return View("EmptyCart");// empty cart view
                }

                int cartSize = Cart.Count();

                List<CartList> CartListModel = new List<CartList>(cartSize);


                foreach (var item in Cart)
                {

                    foreach (var c in CartListModel)
                    {
                        c.itemType = item.ItemType;
                        var itemCost = GetItemCostAsync(item.ItemId, item.ItemType, item.CartId);
                        c.itemPrice = decimal.Parse(itemCost.ToString());
                        var itemName = GetItemNameAsync();
                        c.itemName = itemName.ToString();


                    }

                }



                return View(Cart);
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }
        }

        private async Task<string> GetItemNameAsync()
        {

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Order/GetItemName/{itemId}/{itemType}/{cartId}");

            HttpResponseMessage apiResponse;


            apiResponse = await HttpClient.SendAsync(apiRequest);


            string jsonString = await apiResponse.Content.ReadAsStringAsync();

            string name = JsonConvert.DeserializeObject<string>(jsonString);




            return name;



        }

        private async Task<decimal> GetItemCostAsync(int? itemId, bool? itemType, int cartId)
        {
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Order/GetItemCost/{itemId}/{itemType}/{cartId}");

            HttpResponseMessage apiResponse;


            apiResponse = await HttpClient.SendAsync(apiRequest);


            string jsonString = await apiResponse.Content.ReadAsStringAsync();

            decimal cost = JsonConvert.DeserializeObject<decimal>(jsonString);

            return cost;



        }

        public async Task<ActionResult> Options()//show options to user: locations, date, time
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

                IEnumerable<Location> Locations = JsonConvert.DeserializeObject<IEnumerable<Location>>(jsonString);


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
        [HttpGet("{id}")]
        public async Task<ActionResult> GetProductDetails(int id)
        {

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Order/GetProductsDetails/{id}");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

                Products product = JsonConvert.DeserializeObject<Products>(jsonString);


                return View(product); //send the selected product to view 


            }
            catch (AggregateException ex)
            {
                return View("Error");
            }

        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetServiceDetails(int id)
        {

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Order/GetServiceDetails/{id}");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

                Services service = JsonConvert.DeserializeObject<Services>(jsonString);


                return View(service); //send the selected product to view 


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