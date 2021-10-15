using System.Threading.Tasks;

namespace kns.TourLand.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}