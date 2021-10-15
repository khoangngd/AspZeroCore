using System.Threading.Tasks;
using Abp.Application.Services;
using kns.TourLand.Editions.Dto;
using kns.TourLand.MultiTenancy.Dto;

namespace kns.TourLand.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}