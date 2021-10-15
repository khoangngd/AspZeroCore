using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using kns.TourLand.Authorization;
using kns.TourLand.DashboardCustomization;
using System.Threading.Tasks;
using kns.TourLand.Web.Areas.App.Startup;

namespace kns.TourLand.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(TourLandDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}