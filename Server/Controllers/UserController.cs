using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OpenIdConectBlazor.Server.Context;
using OpenIdConectBlazor.Shared;
using OpenIdConectBlazor.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private ApplicationDbContext context;

        public UserController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost("loginuser")]
        public async Task<ActionResult<User>> LoginUser(User user)
        {
            //User loggedInUser = await context.User.Where(u => u.Email == user.Email).FirstOrDefaultAsync();
            User loggedInUser = await context.User.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefaultAsync();
            if (loggedInUser != null)
            {
                //create a claim
                var claim = new Claim(ClaimTypes.Name, loggedInUser.Email);
               
                //create claimsIdentity
                var claimsIdentity = new ClaimsIdentity(new[] { claim }, "serverAuth");
                //create claimsPrincipal
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                //Sing in user
                await HttpContext.SignInAsync(claimsPrincipal);
               
            }
            else
            if (loggedInUser == null)
            {
                return NotFound("Something went wrong!");
            }
            return await Task.FromResult(loggedInUser);
            // return await Task.FromResult();
        }
        [HttpPost("registeruser")]
        public async Task<ActionResult<User>> Register(User user)
        {
            context.Add(user);
            await context.SaveChangesAsync();
            return user;
        }
        [HttpGet("getcurrentuser")]
        public async Task<ActionResult<User>> GetCurrentUser()
        {
            User currentUser = new User();
            if (User.Identity.IsAuthenticated)
            {
                var email = User.FindFirstValue(ClaimTypes.Name);
                currentUser = await context.User.Where(u => u.Email == email).FirstOrDefaultAsync();
            }
            return await Task.FromResult(currentUser);
        }
        [HttpGet("logoutuser")]
        public async Task<ActionResult<string>> LogOutUser()
        {
            await HttpContext.SignOutAsync();
            return "Success";
        }
        [HttpGet("getprofile/{id}")]
        public async Task<User> GetProfile(int id)
        {
            return await context.User.Where(u => u.Id == id).FirstOrDefaultAsync();
        }
        [HttpPut("updateprofile")]
        public async Task<User> UpdateProfile(User user)
        {
            User userToUpdate = await context.User.Where(u => u.Id == user.Id).FirstOrDefaultAsync();

            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.Email = user.Email;
            userToUpdate.AboutMe = user.AboutMe;

            await context.SaveChangesAsync();
            return await Task.FromResult(user);
        }
    }


}