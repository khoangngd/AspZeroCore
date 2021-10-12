using System.Collections.Generic;
using tls.demo.Editions;
using tls.demo.Editions.Dto;
using tls.demo.MultiTenancy.Payments;
using tls.demo.MultiTenancy.Payments.Dto;

namespace tls.demo.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
