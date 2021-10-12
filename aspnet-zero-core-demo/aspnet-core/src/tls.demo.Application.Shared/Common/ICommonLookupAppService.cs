using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tls.demo.Common.Dto;
using tls.demo.Editions.Dto;

namespace tls.demo.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}