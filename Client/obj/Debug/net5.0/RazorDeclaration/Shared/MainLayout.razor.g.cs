// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OpenIdConectBlazor.Client.Shared
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
#line 1 "D:\IngSoftware\OpenIdConectBlazor\Client\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\IngSoftware\OpenIdConectBlazor\Client\Shared\MainLayout.razor"
      

    private async Task LogOut()
    {
        await httpClient.GetAsync("https://localhost:44357/user/logoutuser");
        navigation.NavigateTo("/",true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositories repository { get; set; }
    }
}
#pragma warning restore 1591
