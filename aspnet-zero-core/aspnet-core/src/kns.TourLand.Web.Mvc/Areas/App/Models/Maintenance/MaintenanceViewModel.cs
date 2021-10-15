using System.Collections.Generic;
using kns.TourLand.Caching.Dto;

namespace kns.TourLand.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}