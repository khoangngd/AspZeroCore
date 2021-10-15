using System.Collections.Generic;
using kns.TourLand.Authorization.Permissions.Dto;

namespace kns.TourLand.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}