using System.Threading.Tasks;
using tls.demo.Authorization.Users;

namespace tls.demo.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
