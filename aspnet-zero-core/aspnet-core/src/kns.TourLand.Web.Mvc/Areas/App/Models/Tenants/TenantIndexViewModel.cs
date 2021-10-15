using System.Collections.Generic;
using kns.TourLand.Editions.Dto;

namespace kns.TourLand.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}