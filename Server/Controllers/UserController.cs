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
            User loggedInUser = await context.User.Where(u => u.Email == user.Email).FirstOrDefaultAsync();
            if (loggedInUser != null)
            {
                //create a claim
                var claim = new Claim(ClaimTypes.Name, user.Email);
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
        public async Task<ActionResult<string>> Register(User user)
        {
            context.Add(user);
            await context.SaveChangesAsync();
            return "usuario guardado";
        }
        [HttpGet("getcurrentuser")]
        public async Task<ActionResult<User>> GetCurrentUser()
        {
            User currentUser = new User();
            if (User.Identity.IsAuthenticated)
            {
                currentUser.Email = User.FindFirstValue(ClaimTypes.Name);
            }
            return await Task.FromResult(currentUser);
        }
        [HttpGet("logoutuser")]
        public async Task<ActionResult<string>> LogOutUser()
        {
            await HttpContext.SignOutAsync();
            return "Success";
        }
    }


}