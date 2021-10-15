using System.Collections.Generic;
using Abp.Application.Services.Dto;
using kns.TourLand.Authorization.Permissions.Dto;
using kns.TourLand.Web.Areas.App.Models.Common;

namespace kns.TourLand.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}