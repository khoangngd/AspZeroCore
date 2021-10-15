using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using kns.TourLand.EntityFrameworkCore;

namespace kns.TourLand.HealthChecks
{
    public class TourLandDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public TourLandDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("TourLandDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("TourLandDbContext could not connect to database"));
        }
    }
}
