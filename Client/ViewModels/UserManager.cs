using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using OpenIdConectBlazor.Client.Repositories;
using OpenIdConectBlazor.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OpenIdConectBlazor.Client.ViewModels
{
    public class UserManager : IUserManager
    {

        // public User User { get; set; }
        public HttpClient HttpClient { get; set; } = new HttpClient();
        [Inject]
        public NavigationManager Navigation { get; set; }

        public Repositorie Repository { get; set; } = new Repositorie();
        //public delegate void CallBack;/*{ get; set; }*/

        //public static void CallBack()
        //{

        //}


        public async Task AddUser(User user, Action CallBack)
        {
            Repository.AddHttpClient(this.HttpClient);
            Uri Uri = new Uri("https://localhost:44357/user/registeruser");
            var HttpResponse = await this.Repository.Post<User>(Uri.AbsoluteUri, user);
            if (HttpResponse.Error)
            {
                var body = HttpResponse.GetBody();
                Console.WriteLine(body);
            }
            else
            {
                Console.WriteLine("estas bien");
                Console.WriteLine(HttpResponse.HttpResponseMessage);
                CallBack();

            }   
        }

     

        public async Task<object> GetUser(long id)
        {
            Repository.AddHttpClient(this.HttpClient);
            User user=new User(); 
            Uri Uri = new Uri("https://localhost:44357/user/getprofile/" + id.ToString());
            var HttpResponse = await this.Repository.Get<User>(Uri.AbsoluteUri);
            if (HttpResponse.Error)
            {
                var body = HttpResponse.GetBody();
                Console.WriteLine(body);
                return user = null; ;
            }
            else
            {
                Console.WriteLine("estas bien");
                Console.WriteLine(HttpResponse.HttpResponseMessage);
                return user=HttpResponse.Response;
            }
  
        }

        

        public async Task LoginUser(User user, Action Action)
        {
            Repository.AddHttpClient(this.HttpClient);
            Uri Uri = new Uri("https://localhost:44357/user/loginuser");
            var HttpResponse = await this.Repository.Post<User, User>(Uri.AbsoluteUri, user);
            if (HttpResponse.Error)
            {
                var body = HttpResponse.GetBody();
                Console.WriteLine(body);
            }
            else
            {
                Console.WriteLine("estas bien");
                var x = HttpResponse.Response;
                Console.WriteLine(x.Email);
                Action();
            }
        }



        public async  Task LogOutUser(Action Action)
        {
            await Repository.Get("https://localhost:44357/user/logoutuser");
            Action();
        }

        public async Task UpdateUser(User user, Action Action)
        {
            Repository.AddHttpClient(this.HttpClient);
            Uri Uri = new Uri("https://localhost:44357/user/updateprofile");
            var HttpResponse = await this.Repository.Put<User>(Uri.AbsoluteUri, user);
            if (HttpResponse.Error)
            {
                var body = HttpResponse.GetBody();
                Console.WriteLine(body);
            }
            else
            {
                Console.WriteLine("estas bien");
                Console.WriteLine(HttpResponse.HttpResponseMessage);
                //CallBack();
                Action();
            }
        }
        public async Task UpdateUser(User user)
        {
            Repository.AddHttpClient(this.HttpClient);
            Uri Uri = new Uri("https://localhost:44357/user/updateprofile");
            var HttpResponse = await this.Repository.Put<User>(Uri.AbsoluteUri, user);
            if (HttpResponse.Error)
            {
                var body = HttpResponse.GetBody();
                Console.WriteLine(body);
            }
            else
            {
                Console.WriteLine("estas bien");
                Console.WriteLine(HttpResponse.HttpResponseMessage);
                
            }
        }
    }
}