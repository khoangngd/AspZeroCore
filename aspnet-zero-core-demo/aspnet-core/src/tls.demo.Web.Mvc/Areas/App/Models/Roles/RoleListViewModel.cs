using System.Collections.Generic;
using Abp.Application.Services.Dto;
using tls.demo.Authorization.Permissions.Dto;
using tls.demo.Web.Areas.App.Models.Common;

namespace tls.demo.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}