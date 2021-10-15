namespace kns.TourLand.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}