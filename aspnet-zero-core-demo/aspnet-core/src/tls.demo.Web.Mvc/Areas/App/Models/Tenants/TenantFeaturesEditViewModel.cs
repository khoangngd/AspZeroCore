using Abp.AutoMapper;
using tls.demo.MultiTenancy;
using tls.demo.MultiTenancy.Dto;
using tls.demo.Web.Areas.App.Models.Common;

namespace tls.demo.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}