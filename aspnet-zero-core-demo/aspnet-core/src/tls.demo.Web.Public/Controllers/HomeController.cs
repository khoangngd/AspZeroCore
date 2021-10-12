using Microsoft.AspNetCore.Mvc;
using tls.demo.Web.Controllers;

namespace tls.demo.Web.Public.Controllers
{
    public class HomeController : demoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}