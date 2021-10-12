using System.Threading.Tasks;
using Abp.Dependency;

namespace tls.demo.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}