using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kns.TourLand.Web.Areas.App.Models.Layout;
using kns.TourLand.Web.Session;
using kns.TourLand.Web.Views;

namespace kns.TourLand.Web.Areas.App.Views.Shared.Components.AppLogo
{
    public class AppLogoViewComponent : TourLandViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppLogoViewComponent(
            IPerRequestSessionCache sessionCache
        )
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var headerModel = new LogoViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
                LogoSkinOverride = logoSkin,
                LogoClassOverride = logoClass
            };

            return View(headerModel);
        }
    }
}
