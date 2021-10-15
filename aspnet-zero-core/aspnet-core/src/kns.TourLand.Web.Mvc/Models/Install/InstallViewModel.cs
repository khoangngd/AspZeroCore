using System.Collections.Generic;
using Abp.Localization;
using kns.TourLand.Install.Dto;

namespace kns.TourLand.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
