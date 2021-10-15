using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using kns.TourLand.Web.Controllers;

namespace kns.TourLand.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : TourLandControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}