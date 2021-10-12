using System.Threading.Tasks;
using Abp.Application.Services;
using tls.demo.Sessions.Dto;

namespace tls.demo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
