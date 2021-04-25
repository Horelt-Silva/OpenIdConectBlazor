using System.Threading.Tasks;
using OpenIdConectBlazor.Shared.Models;

namespace OpenIdConectBlazor.Client.ViewModels
{
    public interface ILoginViewModel
    {
        
        public Task LoginUser();
        public void AddUser(User user);

    }
}