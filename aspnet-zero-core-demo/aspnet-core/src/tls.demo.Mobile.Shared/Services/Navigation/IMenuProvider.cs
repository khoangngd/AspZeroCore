using System.Collections.Generic;
using MvvmHelpers;
using tls.demo.Models.NavigationMenu;

namespace tls.demo.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}