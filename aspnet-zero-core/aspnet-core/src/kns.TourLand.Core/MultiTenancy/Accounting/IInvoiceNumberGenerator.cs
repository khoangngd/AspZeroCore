using System.Threading.Tasks;
using Abp.Dependency;

namespace kns.TourLand.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}