using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace kns.TourLand.Web.Public.Views
{
    public abstract class TourLandRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TourLandRazorPage()
        {
            LocalizationSourceName = TourLandConsts.LocalizationSourceName;
        }
    }
}
