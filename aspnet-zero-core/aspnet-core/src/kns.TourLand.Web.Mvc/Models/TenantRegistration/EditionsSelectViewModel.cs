using Abp.AutoMapper;
using kns.TourLand.MultiTenancy.Dto;

namespace kns.TourLand.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
