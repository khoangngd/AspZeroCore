using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tls.demo.Authorization.Users.Dto;

namespace tls.demo.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<PagedResultDto<UserLoginAttemptDto>> GetUserLoginAttempts(GetLoginAttemptsInput input);
    }
}
