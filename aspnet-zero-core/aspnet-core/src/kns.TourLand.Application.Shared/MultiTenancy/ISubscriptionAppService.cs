using System.Threading.Tasks;
using Abp.Application.Services;

namespace kns.TourLand.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
