using System.Collections.Generic;
using Abp.Application.Services.Dto;
using tls.demo.Editions.Dto;

namespace tls.demo.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}