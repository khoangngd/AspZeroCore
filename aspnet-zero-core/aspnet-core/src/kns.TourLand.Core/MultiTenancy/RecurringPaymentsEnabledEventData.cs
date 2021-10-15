using Abp.Events.Bus;

namespace kns.TourLand.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}