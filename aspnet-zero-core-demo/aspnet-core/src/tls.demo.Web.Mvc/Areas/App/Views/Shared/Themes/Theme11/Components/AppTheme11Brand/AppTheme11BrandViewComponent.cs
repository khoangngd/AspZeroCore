using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tls.demo.Web.Areas.App.Models.Layout;
using tls.demo.Web.Session;
using tls.demo.Web.Views;

namespace tls.demo.Web.Areas.App.Views.Shared.Themes.Theme11.Components.AppTheme11Brand
{
    public class AppTheme11BrandViewComponent : demoViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme11BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
