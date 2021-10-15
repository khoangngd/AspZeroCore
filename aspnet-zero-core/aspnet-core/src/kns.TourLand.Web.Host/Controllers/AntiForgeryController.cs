using Microsoft.AspNetCore.Antiforgery;

namespace kns.TourLand.Web.Controllers
{
    public class AntiForgeryController : TourLandControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
