using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HappyPets.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HappyPets.WebApp.Controllers
{
    public class UsersController : AServiceController
    {

        public UsersController(HttpClient httpClient) : base(httpClient)
        { }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        


        
        public async Task<ActionResult> GetUsers()
        {
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Get, "api/Users/GetUsers");

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);

                if (!apiResponse.IsSuccessStatusCode)
                {
                    return View("AccessDenied");
                }

                string jsonString = await apiResponse.Content.ReadAsStringAsync();
                IEnumerable<Users> GetUsers = JsonConvert.DeserializeObject<IEnumerable<Users>>(jsonString);
                return View(GetUsers);
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }

            //if (!apiResponse.IsSuccessStatusCode)
            //{
            //    if (apiResponse.StatusCode == HttpStatusCode.Forbidden)
            //    {
            //        return View("AccessDenied");
            //    }
            //    return View("Error");
            //}

            //PassCookiesToClient(apiResponse);

           // return View("GetUsers");
        }


        private bool PassCookiesToClient(HttpResponseMessage apiResponse)
        {
            if (apiResponse.Headers.TryGetValues("Set-Cookie", out IEnumerable<string> values))
            {
                string authValue = values.FirstOrDefault(x => x.StartsWith(s_CookieName));
                if (authValue != null)
                {
                    Response.Headers.Add("Set-Cookie", authValue);
                    return true;
                }
            }
            return false;
        }



    }
}