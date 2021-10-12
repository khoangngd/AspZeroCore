using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace tls.demo.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
