using System.Threading.Tasks;
using Abp.Application.Services;
using tls.demo.MultiTenancy.Payments.Dto;
using tls.demo.MultiTenancy.Payments.Stripe.Dto;

namespace tls.demo.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}