using System.Threading.Tasks;
using Abp.Application.Services;
using kns.TourLand.Sessions.Dto;

namespace kns.TourLand.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
