using Abp.AspNetCore.Mvc.Authorization;
using kns.TourLand.Authorization;
using kns.TourLand.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace kns.TourLand.Web.Controllers
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