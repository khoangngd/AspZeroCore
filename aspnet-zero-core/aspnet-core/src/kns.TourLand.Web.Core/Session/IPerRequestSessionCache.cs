using System.Threading.Tasks;
using kns.TourLand.Sessions.Dto;

namespace kns.TourLand.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
