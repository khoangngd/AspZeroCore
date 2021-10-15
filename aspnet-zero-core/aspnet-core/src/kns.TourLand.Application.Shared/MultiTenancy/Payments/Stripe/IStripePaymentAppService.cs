using System.Threading.Tasks;
using Abp.Application.Services;
using kns.TourLand.MultiTenancy.Payments.Dto;
using kns.TourLand.MultiTenancy.Payments.Stripe.Dto;

namespace kns.TourLand.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}