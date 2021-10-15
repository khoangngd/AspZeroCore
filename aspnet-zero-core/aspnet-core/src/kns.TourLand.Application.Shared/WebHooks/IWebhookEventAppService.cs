using System.Threading.Tasks;
using Abp.Webhooks;

namespace kns.TourLand.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
