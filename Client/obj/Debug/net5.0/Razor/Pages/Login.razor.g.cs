#pragma checksum "D:\IngSoftware\OpenIdConectBlazor\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29ae5d3ee081892c037ad0cc261bdb4cfbd1c4d5"
// <auto-generated/>
#pragma warning disable 1591
namespace OpenIdConectBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using OpenIdConectBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using OpenIdConectBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using OpenIdConectBlazor.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using OpenIdConectBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\IngSoftware\OpenIdConectBlazor\Client\_Imports.razor"
using OpenIdConectBlazor.Client.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\IngSoftware\OpenIdConectBlazor\Client\Pages\Login.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "model", "user");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "d-flex flex-column");
                __builder2.AddMarkupContent(5, "<div class=\"row\">Login Form</div>\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "type", "email");
                __builder2.AddAttribute(10, "class", "form-control");
                __builder2.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\IngSoftware\OpenIdConectBlazor\Client\Pages\Login.razor"
                                       user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Email = __value, user.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "row");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "password");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\IngSoftware\OpenIdConectBlazor\Client\Pages\Login.razor"
                                          user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "row");
                __builder2.OpenElement(24, "button");
                __builder2.AddAttribute(25, "class", "btn btn-primary");
                __builder2.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\IngSoftware\OpenIdConectBlazor\Client\Pages\Login.razor"
                                                      Create

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(27, "Login");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "D:\IngSoftware\OpenIdConectBlazor\Client\Pages\Login.razor"
      
    User user = new User();
    //[CascadingParameter]
    //public Task<AuthenticationState> authenticationState { get; set; }

    //public async Task Create()
    //{
    //    ////LoginViewModel LoginModel = new LoginViewModel(user);
    //    //LoginModel.AddUser(user);
    //    //await LoginModel.LoginUser();
    //    //navigation.NavigateTo("/profile", true);
    //    //var authState = await authenticationState;
    //    Uri Uri = new Uri("https://localhost:44357/user/loginuser");
    //    var HttpResponse = await repository.Post<User, User>(Uri.AbsoluteUri, user);
    //    if (HttpResponse.Error)
    //    {
    //        var body = HttpResponse.GetBody();
    //        Console.WriteLine(body);
    //    }
    //    else
    //    {
    //        Console.WriteLine("estas bien");
    //        var x = HttpResponse.Response;
    //        //authState.User = HttpResponse.Response;
    //        Console.WriteLine(x.Email);
    //        await JsRuntime.InvokeVoidAsync("alert", x.Id);
    //        navigation.NavigateTo("/profile", true);

    //    }
    //}
    public async Task Create()
    {
        await UserManager.LoginUser(user, ()=>this.navigation.NavigateTo("/profile", true));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserManager UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositories repository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
    }
}
#pragma warning restore 1591
