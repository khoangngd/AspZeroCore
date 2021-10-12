using System.Threading.Tasks;

namespace tls.demo.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}