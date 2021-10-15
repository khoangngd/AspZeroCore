using Abp.Application.Services;
using kns.TourLand.Dto;
using kns.TourLand.Logging.Dto;

namespace kns.TourLand.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
