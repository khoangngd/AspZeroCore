using System.Threading.Tasks;
using Abp.Application.Services;
using tls.demo.MultiTenancy.Payments.PayPal.Dto;

namespace tls.demo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
