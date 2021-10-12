using Microsoft.Extensions.Configuration;

namespace tls.demo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
