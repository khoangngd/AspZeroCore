using System.Threading.Tasks;
using Abp.Authorization.Users;
using kns.TourLand.Authorization.Users;

namespace kns.TourLand.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}
