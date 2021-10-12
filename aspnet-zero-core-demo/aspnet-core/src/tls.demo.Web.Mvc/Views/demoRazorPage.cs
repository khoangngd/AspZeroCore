using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.Extensions.Configuration;
using tls.demo.Configuration;
using tls.demo.Localization;
using tls.demo.UiCustomization;
using tls.demo.UiCustomization.Dto;

namespace tls.demo.Web.Views
{
    public abstract class demoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject] public IAbpSession AbpSession { get; set; }

        [RazorInject] public IUiThemeCustomizerFactory UiThemeCustomizerFactory { get; set; }

        [RazorInject] public IAppConfigurationAccessor AppConfigurationAccessor { get; set; }

        protected demoRazorPage()
        {
            LocalizationSourceName = demoConsts.LocalizationSourceName;
        }

        public async Task<UiCustomizationSettingsDto> GetTheme()
        {
            var themeCustomizer = await UiThemeCustomizerFactory.GetCurrentUiCustomizer();
            var settings = await themeCustomizer.GetUiSettings();
            return settings;
        }

        public async Task<string> GetContainerClass()
        {
            var theme = await GetTheme();
            return theme.BaseSettings.Layout.LayoutType == "fluid" ? "container-fluid" : "container";
        }

        public string GetMomentLocale()
        {
            if (CultureHelper.UsingLunarCalendar)
            {
                return "en";
            }

            var momentLocaleMapping = AppConfigurationAccessor.Configuration.GetSection("LocaleMappings:Moment").Get<List<LocaleMappingInfo>>();
            if (momentLocaleMapping == null)
            {
                return CultureInfo.CurrentUICulture.Name;
            }

            var mapping = momentLocaleMapping.FirstOrDefault(e => e.From == CultureInfo.CurrentUICulture.Name);
            if (mapping == null)
            {
                return CultureInfo.CurrentUICulture.Name;
            }

            return mapping.To;
        }
    }
}
