using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HappyPets.Data;
using Microsoft.AspNetCore.Mvc;

namespace HappyPets.WebApp.Controllers
{
    public class UsersController : AServiceController
    {

        public UsersController(HttpClient httpClient) : base(httpClient)
        { }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> GetUsers(Users account)
        {
            HttpRequestMessage apiRequest = CreateRequestToService(HttpMethod.Post, "api/Users/GetUsers", account);

            HttpResponseMessage apiResponse;
            try
            {
                apiResponse = await HttpClient.SendAsync(apiRequest);
            }
            catch (AggregateException ex)
            {
                return View("Error");
            }

            if (!apiResponse.IsSuccessStatusCode)
            {
                if (apiResponse.StatusCode == HttpStatusCode.Forbidden)
                {
                    return View("AccessDenied");
                }
                return View("Error");
            }

            PassCookiesToClient(apiResponse);

            return RedirectToAction("Index", "Home");
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