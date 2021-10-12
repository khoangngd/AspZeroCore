using Abp.AutoMapper;
using tls.demo.MultiTenancy.Dto;

namespace tls.demo.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
