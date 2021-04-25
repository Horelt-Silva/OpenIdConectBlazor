using Microsoft.AspNetCore.Components.Authorization;
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
    public class LoginViewModel : ILoginViewModel
    {
        public LoginViewModel(User user, HttpClient httpClient)
        {
            User = user;
            HttpClient = httpClient;
        }

        public User User { get; set; }
        public HttpClient HttpClient { get; set; }
       

        public async Task LoginUser()
        {
            //Repositorie repository = new Repositorie(this.HttpClient);
            //Uri Uri = new Uri("https://localhost:44357/user/loginuser");
            //var HttpResponse = await repository.Post<User, User>(Uri.AbsoluteUri, User);
            //if (HttpResponse.Error)
            //{
            //    var body = HttpResponse.GetBody();
            //    Console.WriteLine(body);
            //}
            //else
            //{
            //    Console.WriteLine("estas bien");
            //    var x = HttpResponse.Response;
            //    Console.WriteLine(x.Email);
            //}
        }
        public void AddUser(User user)
        {
            user = User;
        }


    }
}