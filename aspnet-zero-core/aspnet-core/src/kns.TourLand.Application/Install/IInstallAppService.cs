using System.Threading.Tasks;
using Abp.Application.Services;
using kns.TourLand.Install.Dto;

namespace kns.TourLand.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}