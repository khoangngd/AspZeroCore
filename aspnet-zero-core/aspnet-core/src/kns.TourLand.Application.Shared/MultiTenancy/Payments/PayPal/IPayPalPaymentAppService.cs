using System.Threading.Tasks;
using Abp.Application.Services;
using kns.TourLand.MultiTenancy.Payments.PayPal.Dto;

namespace kns.TourLand.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
