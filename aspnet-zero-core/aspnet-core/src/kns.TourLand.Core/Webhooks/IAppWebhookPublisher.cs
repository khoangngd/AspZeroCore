using System.Threading.Tasks;
using kns.TourLand.Authorization.Users;

namespace kns.TourLand.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
