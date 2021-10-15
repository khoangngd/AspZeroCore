using System.Threading.Tasks;
using Abp.Application.Services;
using kns.TourLand.Configuration.Host.Dto;

namespace kns.TourLand.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
