using System.Collections.Generic;
using tls.demo.Caching.Dto;

namespace tls.demo.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}