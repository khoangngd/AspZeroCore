using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using tls.demo.Editions.Dto;
using tls.demo.Web.Areas.App.Models.Common;

namespace tls.demo.Web.Areas.App.Models.Editions
{
    [AutoMapFrom(typeof(GetEditionEditOutput))]
    public class CreateEditionModalViewModel : GetEditionEditOutput, IFeatureEditViewModel
    {
        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public IReadOnlyList<ComboboxItemDto> FreeEditionItems { get; set; }
    }
}