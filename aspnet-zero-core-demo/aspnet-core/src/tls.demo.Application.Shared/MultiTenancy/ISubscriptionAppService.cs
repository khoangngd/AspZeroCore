using System.Threading.Tasks;
using Abp.Application.Services;

namespace tls.demo.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
