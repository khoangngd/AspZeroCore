using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using tls.demo.MultiTenancy.Accounting.Dto;

namespace tls.demo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
