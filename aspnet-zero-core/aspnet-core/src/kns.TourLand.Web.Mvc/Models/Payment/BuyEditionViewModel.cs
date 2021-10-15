using System.Collections.Generic;
using kns.TourLand.Editions;
using kns.TourLand.Editions.Dto;
using kns.TourLand.MultiTenancy.Payments;
using kns.TourLand.MultiTenancy.Payments.Dto;

namespace kns.TourLand.Web.Models.Payment
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
