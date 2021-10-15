using System.Collections.Generic;
using kns.TourLand.Editions.Dto;
using kns.TourLand.MultiTenancy.Payments;

namespace kns.TourLand.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}