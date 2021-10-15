using Microsoft.Extensions.Configuration;

namespace kns.TourLand.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
