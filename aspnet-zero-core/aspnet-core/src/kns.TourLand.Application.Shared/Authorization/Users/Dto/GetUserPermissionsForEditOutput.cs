using System.Collections.Generic;
using kns.TourLand.Authorization.Permissions.Dto;

namespace kns.TourLand.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}