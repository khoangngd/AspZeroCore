using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kns.TourLand.Authorization.Permissions.Dto;

namespace kns.TourLand.Web.Areas.App.Models.Common.Modals
{
    public class PermissionTreeModalViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }
        public List<string> GrantedPermissionNames { get; set; }
    }
}
