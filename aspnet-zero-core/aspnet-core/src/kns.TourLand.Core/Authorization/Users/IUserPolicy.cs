using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace kns.TourLand.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
