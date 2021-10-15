using Abp.Authorization;
using kns.TourLand.Authorization.Roles;
using kns.TourLand.Authorization.Users;

namespace kns.TourLand.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
