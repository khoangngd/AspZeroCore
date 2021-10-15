using kns.TourLand.MultiTenancy.Payments;

namespace kns.TourLand.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}