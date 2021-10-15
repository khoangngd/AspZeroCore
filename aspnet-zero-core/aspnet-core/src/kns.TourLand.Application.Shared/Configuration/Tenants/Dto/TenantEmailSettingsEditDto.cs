using Abp.Auditing;
using kns.TourLand.Configuration.Dto;

namespace kns.TourLand.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}