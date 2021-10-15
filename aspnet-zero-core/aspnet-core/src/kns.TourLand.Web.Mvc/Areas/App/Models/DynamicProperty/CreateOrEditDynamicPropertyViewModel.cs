using System.Collections.Generic;
using kns.TourLand.DynamicEntityProperties.Dto;

namespace kns.TourLand.Web.Areas.App.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
