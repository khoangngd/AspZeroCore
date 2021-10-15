using Abp.Domain.Services;

namespace kns.TourLand
{
    public abstract class TourLandDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected TourLandDomainServiceBase()
        {
            LocalizationSourceName = TourLandConsts.LocalizationSourceName;
        }
    }
}
