using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using kns.TourLand.MultiTenancy.Accounting.Dto;

namespace kns.TourLand.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
