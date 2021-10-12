using System.Threading.Tasks;
using tls.demo.Sessions.Dto;

namespace tls.demo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
