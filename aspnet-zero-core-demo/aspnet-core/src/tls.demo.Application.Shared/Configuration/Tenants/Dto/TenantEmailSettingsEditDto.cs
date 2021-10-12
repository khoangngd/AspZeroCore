using Abp.Auditing;
using tls.demo.Configuration.Dto;

namespace tls.demo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}