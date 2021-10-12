using System.Collections.Generic;
using tls.demo.Authorization.Permissions.Dto;

namespace tls.demo.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}