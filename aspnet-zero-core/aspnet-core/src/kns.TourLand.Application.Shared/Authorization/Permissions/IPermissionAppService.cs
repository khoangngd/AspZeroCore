using Abp.Application.Services;
using Abp.Application.Services.Dto;
using kns.TourLand.Authorization.Permissions.Dto;

namespace kns.TourLand.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
