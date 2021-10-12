using Abp.AspNetCore.Mvc.ViewComponents;

namespace tls.demo.Web.Public.Views
{
    public abstract class demoViewComponent : AbpViewComponent
    {
        protected demoViewComponent()
        {
            LocalizationSourceName = demoConsts.LocalizationSourceName;
        }
    }
}