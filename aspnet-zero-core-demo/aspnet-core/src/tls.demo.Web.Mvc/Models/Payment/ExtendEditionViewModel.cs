﻿using System.Collections.Generic;
using tls.demo.Editions.Dto;
using tls.demo.MultiTenancy.Payments;

namespace tls.demo.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}