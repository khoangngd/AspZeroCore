using System.Threading.Tasks;
using Abp.Application.Services;
using tls.demo.Install.Dto;

namespace tls.demo.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}