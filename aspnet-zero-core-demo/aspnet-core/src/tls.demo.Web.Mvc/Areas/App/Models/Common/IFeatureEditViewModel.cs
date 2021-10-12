using System.Collections.Generic;
using Abp.Application.Services.Dto;
using tls.demo.Editions.Dto;

namespace tls.demo.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}