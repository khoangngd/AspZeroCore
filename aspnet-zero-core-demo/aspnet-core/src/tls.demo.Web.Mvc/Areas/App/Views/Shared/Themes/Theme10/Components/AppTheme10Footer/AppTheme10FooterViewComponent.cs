using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tls.demo.Web.Areas.App.Models.Layout;
using tls.demo.Web.Session;
using tls.demo.Web.Views;

namespace tls.demo.Web.Areas.App.Views.Shared.Themes.Theme10.Components.AppTheme10Footer
{
    public class AppTheme10FooterViewComponent : demoViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme10FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
