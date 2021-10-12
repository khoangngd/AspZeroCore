using System.Threading.Tasks;
using Abp.Application.Services;
using tls.demo.Configuration.Tenants.Dto;

namespace tls.demo.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
