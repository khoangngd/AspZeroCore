﻿using tls.demo.Editions;
using tls.demo.MultiTenancy.Payments;

namespace tls.demo.Web.Models.Payment
{
    public class CreatePaymentModel
    {
        public int EditionId { get; set; }

        public PaymentPeriodType? PaymentPeriodType { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public bool? RecurringPaymentEnabled { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}
