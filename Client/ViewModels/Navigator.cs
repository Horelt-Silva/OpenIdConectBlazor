using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace OpenIdConectBlazor.Client.ViewModels
{
    public class Navigator : NavigationManager
    {
        protected override void NavigateToCore(string uri, bool forceLoad)
        {
            throw new NotImplementedException();
        }
    }
}
