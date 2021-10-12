using System.ComponentModel.DataAnnotations;
using tls.demo.Configuration.Dto;
using tls.demo.Configuration.Tenants.Dto;

namespace tls.demo.Configuration.Host.Dto
{
    public class HostSettingsEditDto
    {
        [Required]
        public GeneralSettingsEditDto General { get; set; }

        [Required]
        public HostUserManagementSettingsEditDto UserManagement { get; set; }

        [Required]
        public EmailSettingsEditDto Email { get; set; }

        [Required]
        public TenantManagementSettingsEditDto TenantManagement { get; set; }

        [Required]
        public SecuritySettingsEditDto Security { get; set; }

        public HostBillingSettingsEditDto Billing { get; set; }

        public OtherSettingsEditDto OtherSettings { get; set; }

        public ExternalLoginProviderSettingsEditDto ExternalLoginProviderSettings { get; set; }
    }
}