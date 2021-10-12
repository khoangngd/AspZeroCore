using Abp.Authorization;
using tls.demo.Authorization.Roles;
using tls.demo.Authorization.Users;

namespace tls.demo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
