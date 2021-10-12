using System.Threading.Tasks;
using Abp.Webhooks;

namespace tls.demo.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
