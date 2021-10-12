using System.Collections.Generic;
using tls.demo.Editions.Dto;

namespace tls.demo.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}