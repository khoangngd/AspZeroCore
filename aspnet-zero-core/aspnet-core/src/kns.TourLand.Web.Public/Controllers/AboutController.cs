using Microsoft.AspNetCore.Mvc;
using kns.TourLand.Web.Controllers;

namespace kns.TourLand.Web.Public.Controllers
{
    public class AboutController : TourLandControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}