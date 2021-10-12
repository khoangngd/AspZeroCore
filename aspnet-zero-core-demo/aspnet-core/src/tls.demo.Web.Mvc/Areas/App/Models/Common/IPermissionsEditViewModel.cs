using System.Collections.Generic;
using tls.demo.Authorization.Permissions.Dto;

namespace tls.demo.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}