using System.Collections.Generic;
using kns.TourLand.Authorization.Permissions.Dto;

namespace kns.TourLand.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}