using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tls.demo.Caching.Dto;

namespace tls.demo.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
