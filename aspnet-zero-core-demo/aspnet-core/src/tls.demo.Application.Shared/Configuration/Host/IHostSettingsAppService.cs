using System.Threading.Tasks;
using Abp.Application.Services;
using tls.demo.Configuration.Host.Dto;

namespace tls.demo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
