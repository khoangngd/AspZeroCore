using Abp.AspNetCore.Mvc.Views;

namespace kns.TourLand.Web.Views
{
    public abstract class TourLandRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected TourLandRazorPage()
        {
            LocalizationSourceName = TourLandConsts.LocalizationSourceName;
        }
    }
}
