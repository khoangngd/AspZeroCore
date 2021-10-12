using System.Threading.Tasks;
using Abp.Application.Services;
using tls.demo.Editions.Dto;
using tls.demo.MultiTenancy.Dto;

namespace tls.demo.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}