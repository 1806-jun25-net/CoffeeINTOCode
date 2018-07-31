using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HappyPets.Data;
using HappyPets.Library;
using Microsoft.AspNetCore.Authorization;

namespace HappyPets.WepApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private readonly HappyPetsDBContext _context;
       
        public Repository Repo { get; set; }


        public UsersController(Repository repo)
        {
            //_context = context;
            Repo = repo;
        }

        [HttpGet]
        //[Authorize]
        public IEnumerable<Users> GetUsers()
        {
            var user = Repo.GetUsertable().ToList();
            return user;
            //var TheUser = user.FirstOrDefault(x => x.FirstName == "YESSEBELL");
            //return new string[] { $"Name: {TheUser.FirstName}" + $" Last Name: {TheUser.LastName}"
            //    + $" Registration Email: {TheUser.Email}"};
        } 

    }
}
