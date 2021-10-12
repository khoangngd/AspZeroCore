using System.Collections.Generic;
using Abp.Localization;
using tls.demo.Install.Dto;

namespace tls.demo.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
