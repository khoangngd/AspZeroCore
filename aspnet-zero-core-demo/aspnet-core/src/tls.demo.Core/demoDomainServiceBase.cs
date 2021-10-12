using Abp.Domain.Services;

namespace tls.demo
{
    public abstract class demoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected demoDomainServiceBase()
        {
            LocalizationSourceName = demoConsts.LocalizationSourceName;
        }
    }
}
