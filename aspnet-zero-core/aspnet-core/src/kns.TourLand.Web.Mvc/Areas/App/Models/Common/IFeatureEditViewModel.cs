﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using kns.TourLand.Editions.Dto;

namespace kns.TourLand.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}