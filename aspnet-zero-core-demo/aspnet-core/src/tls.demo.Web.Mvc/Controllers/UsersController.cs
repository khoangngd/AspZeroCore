using Abp.AspNetCore.Mvc.Authorization;
using tls.demo.Authorization;
using tls.demo.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace tls.demo.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}