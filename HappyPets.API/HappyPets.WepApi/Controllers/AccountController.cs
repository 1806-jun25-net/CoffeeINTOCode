﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyPets.Data;
using HappyPets.Library.Repository;
using HappyPets.WepApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HappyPets.WepApi.Controllers
{
    


    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : Controller
    {
        private SignInManager<IdentityUser> _signInManager { get; }
        public Repository Repo;

        public AccountController(SignInManager<IdentityUser> signInManager, Repository repo)
        {
            _signInManager = signInManager;
            Repo = repo;
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(403)]
        public async Task<ActionResult> Login(User input)
        {
            
            //ViewData["current_user"] = input.Username;
           // string username = input.Username;
           // string user = HttpContext.User.Identity.Name;
           

            var result = await _signInManager.PasswordSignInAsync(input.Username, input.Password,
                isPersistent: false, lockoutOnFailure: false);

            if (!result.Succeeded)
            {
                return StatusCode(403); // Forbidden
            }

            return NoContent();

        }

        [HttpPost]
        [ProducesResponseType(204)]
        public async Task<NoContentResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return NoContent();
        }

        [HttpPost]
        //[Authorize]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Register(User input,
            [FromServices] UserManager<IdentityUser> userManager,
            [FromServices] RoleManager<IdentityRole> roleManager, bool admin = false)
        {
            // with an [ApiController], model state is always automatically checked
            // and return 400 if any errors.

            var user = new IdentityUser(input.Username);

            var result = await userManager.CreateAsync(user, input.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result);
            }

            if (admin)
            {
                if (!(await roleManager.RoleExistsAsync("admin")))
                {
                    var adminRole = new IdentityRole("admin");
                    result = await roleManager.CreateAsync(adminRole);
                    if (!result.Succeeded)
                    {

                        return StatusCode(500, result);
                    }

                }
                result = await userManager.AddToRoleAsync(user, "admin");
                if (!result.Succeeded)
                {
                    return StatusCode(500, result);
                }
            }
            Users newUser = new Users
            {
                UserName = input.Username,

                FirstName = " ",
                LastName = " ",
                Email = " ",
                LocationId = 1,
                Passwords = " "
                //int ? employeeId)

            };

            Repo.CreateNewUser(newUser);


            await _signInManager.SignInAsync(user, isPersistent: false);

            return NoContent();
        }


    }
}