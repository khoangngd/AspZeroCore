using Abp.AspNetCore.Mvc.ViewComponents;

namespace tls.demo.Web.Views
{
    public abstract class demoViewComponent : AbpViewComponent
    {
        protected demoViewComponent()
        {
            LocalizationSourceName = demoConsts.LocalizationSourceName;
        }
    }
}