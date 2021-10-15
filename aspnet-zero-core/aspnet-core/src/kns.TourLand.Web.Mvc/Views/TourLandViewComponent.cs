using Abp.AspNetCore.Mvc.ViewComponents;

namespace kns.TourLand.Web.Views
{
    public abstract class TourLandViewComponent : AbpViewComponent
    {
        protected TourLandViewComponent()
        {
            LocalizationSourceName = TourLandConsts.LocalizationSourceName;
        }
    }
}