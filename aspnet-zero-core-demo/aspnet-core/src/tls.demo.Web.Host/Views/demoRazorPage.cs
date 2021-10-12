using Abp.AspNetCore.Mvc.Views;

namespace tls.demo.Web.Views
{
    public abstract class demoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected demoRazorPage()
        {
            LocalizationSourceName = demoConsts.LocalizationSourceName;
        }
    }
}
