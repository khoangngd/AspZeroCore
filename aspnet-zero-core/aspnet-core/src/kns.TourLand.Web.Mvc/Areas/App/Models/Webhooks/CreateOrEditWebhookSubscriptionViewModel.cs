using Abp.Application.Services.Dto;
using Abp.Webhooks;
using kns.TourLand.WebHooks.Dto;

namespace kns.TourLand.Web.Areas.App.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
