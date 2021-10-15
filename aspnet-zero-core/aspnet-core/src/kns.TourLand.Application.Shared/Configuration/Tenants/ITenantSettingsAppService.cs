using System.Threading.Tasks;
using Abp.Application.Services;
using kns.TourLand.Configuration.Tenants.Dto;

namespace kns.TourLand.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
