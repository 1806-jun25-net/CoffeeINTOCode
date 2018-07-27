using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HappyPets.Data;
using HappyPets.Library;

namespace HappyPets.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private readonly HappyPetsDBContext _context;
       
        public URepository Repo { get; set; }


        public UsersController(URepository repo)
        {
            //_context = context;
            Repo = repo;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var user = Repo.GetUsertable();
            var TheUser = user.FirstOrDefault(x => x.FirstName == "YESSEBELL");
            return new string[] { $"Name: {TheUser.FirstName}" + $" Last Name: {TheUser.LastName}"
                + $" Registration Date: {TheUser.Email}"};
        } // Print in webpage
    }
}
