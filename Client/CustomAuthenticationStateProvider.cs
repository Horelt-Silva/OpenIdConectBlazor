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


namespace OpenIdConectBlazor.Client
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient httpClient;

        public CustomAuthenticationStateProvider(HttpClient httpClient)
        {

            this.httpClient = httpClient;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            User currentUser = await httpClient.GetFromJsonAsync<User>("user/getcurrentuser");
            if (currentUser != null && currentUser.Email != null)
            {
                //create a claim
                Console.WriteLine(currentUser.Id);
                var claimEmail = new Claim(ClaimTypes.Name, currentUser.Email);
                var claimNameIdentifier = new Claim(ClaimTypes.NameIdentifier, Convert.ToString(currentUser.Id));
                //create claimsIdentity
                var claimsIdentity = new ClaimsIdentity(new[] { claimEmail, claimNameIdentifier }, "serverAuth");
                //create claimsPrincipal
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                return new AuthenticationState(claimsPrincipal);

            }
            else
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
        }
    }
}
