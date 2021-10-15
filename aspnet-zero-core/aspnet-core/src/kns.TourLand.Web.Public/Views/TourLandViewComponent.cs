using Abp.AspNetCore.Mvc.ViewComponents;

namespace kns.TourLand.Web.Public.Views
{
    public abstract class TourLandViewComponent : AbpViewComponent
    {
        protected TourLandViewComponent()
        {
            LocalizationSourceName = TourLandConsts.LocalizationSourceName;
        }
    }
}