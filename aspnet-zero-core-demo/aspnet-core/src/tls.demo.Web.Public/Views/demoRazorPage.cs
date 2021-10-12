using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace tls.demo.Web.Public.Views
{
    public abstract class demoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected demoRazorPage()
        {
            LocalizationSourceName = demoConsts.LocalizationSourceName;
        }
    }
}
