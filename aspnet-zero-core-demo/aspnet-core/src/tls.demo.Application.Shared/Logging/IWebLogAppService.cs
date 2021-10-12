using Abp.Application.Services;
using tls.demo.Dto;
using tls.demo.Logging.Dto;

namespace tls.demo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
