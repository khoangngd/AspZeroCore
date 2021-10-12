namespace tls.demo.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}