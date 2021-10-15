using System.Collections.Generic;
using MvvmHelpers;
using kns.TourLand.Models.NavigationMenu;

namespace kns.TourLand.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}