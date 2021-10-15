using System.Collections.Generic;
using Abp.Application.Services.Dto;
using kns.TourLand.Editions.Dto;

namespace kns.TourLand.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}