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
            string username = TempData.Peek("current_user").ToString();
            Users user = new Users { UserName = username };
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Post, "api/Order/ShowCart", user);

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

                IEnumerable<CartList> Cart = JsonConvert.DeserializeObject<IEnumerable<CartList>>(jsonString);//null if cart is empty
                if (Cart == null)
                {
                    return View("EmptyCart");// empty cart view
                }


                return View(Cart);
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }
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

            Choosen choosen = new Choosen
            {
                LocationId = location,
                Time = time,
                Date = date
            };


            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Post, "api/Order/Choose", choosen);

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

                if (employees == null)
                {
                    return View("NoEmployees");
                }
                else
                   return View(employees); //send available employees to view

            }
            catch (AggregateException ex)
            {
                return View("Error");
            }


        }
        //[HttpGet("{id}")]
        public async Task<ActionResult> GetProductDetails(int id)
        {

            ItemDetails item = new ItemDetails { ItemId = id };
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Order/GetProductDetails", item);

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
        //[HttpGet("{id}")]
        public async Task<ActionResult> GetServiceDetails(int id)
        {
            ItemDetails item = new ItemDetails { ItemId = id };
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Order/GetServiceDetails", item);

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
        public  async Task<ActionResult> AddProductsToCart(IFormCollection viewcollection)
        {
            var quantity = int.Parse(viewcollection["selectedQuantity"]);
            var item = int.Parse(viewcollection["selectedId"]);
            string username = TempData.Peek("current_user").ToString();//verify if i can access this here
            
            AddToCart add = new AddToCart
            {
                Quantity = quantity,
                ItemId = item,
                Username = username,
                ItemType = false
                
            };


            

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Post, "api/Order/AddProductToCart", add);


            HttpResponseMessage apiResponse;
            
                apiResponse = await HttpClient.SendAsync(apiRequest);

            return NoContent();

        }


        public async Task<ActionResult> AddServiceToCart(IFormCollection viewcollection)
        {
            var size = viewcollection["selectedSize"];
            var item = int.Parse(viewcollection["selectedId"]);
            string username = TempData.Peek("current_user").ToString();

            AddToCart add = new AddToCart
            {
                Size = size,
                ItemId = item,
                Username = username,
                ItemType = true
              
            };



            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Post, "api/Order/AddServiceToCart", add);


            HttpResponseMessage apiResponse;

            apiResponse = await HttpClient.SendAsync(apiRequest);


            return NoContent();



        }


        public async Task<ActionResult> Checkout(IFormCollection viewcollection)
        {
            string username = TempData.Peek("current_user").ToString();
            var selectedemployeeid = int.Parse(viewcollection["selectedEmployee"]);

            AddToCart add = new AddToCart { EmployeeId = selectedemployeeid, Username = username };

            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Post, "api/Order/Checkout", add);


            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();

               
                OrderDetails order = JsonConvert.DeserializeObject<OrderDetails>(jsonString);


                return View(order); //send the selected product to view 


            }
            catch (AggregateException ex)
            {
                return View("Error");
            }



        }

        public async Task<ActionResult> PlaceOrder(IFormCollection viewcollection)
        {
            int? orderid = int.Parse(viewcollection["orderId"]);

            MyOrder order = new MyOrder { OrderId = orderid };
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Post, "api/Order/PlaceOrder", order);


            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();


               // OrderDetails order = JsonConvert.DeserializeObject<OrderDetails>(jsonString);


                return View();


            }
            catch (AggregateException ex)
            {
                return View("Error");
            }


        }






    }
}