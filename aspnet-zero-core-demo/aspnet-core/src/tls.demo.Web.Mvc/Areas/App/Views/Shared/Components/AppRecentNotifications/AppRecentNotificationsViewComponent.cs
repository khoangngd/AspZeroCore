using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tls.demo.Web.Areas.App.Models.Layout;
using tls.demo.Web.Views;

namespace tls.demo.Web.Areas.App.Views.Shared.Components.AppRecentNotifications
{
    public class AppRecentNotificationsViewComponent : demoViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new RecentNotificationsViewModel
            {
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
