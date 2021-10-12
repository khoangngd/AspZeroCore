using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tls.demo.Authorization.Permissions.Dto;

namespace tls.demo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
