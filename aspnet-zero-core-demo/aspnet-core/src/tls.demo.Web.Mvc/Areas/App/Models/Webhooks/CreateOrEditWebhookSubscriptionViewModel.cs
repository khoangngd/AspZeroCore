﻿using Abp.Application.Services.Dto;
using Abp.Webhooks;
using tls.demo.WebHooks.Dto;

namespace tls.demo.Web.Areas.App.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
