using Abp;

namespace kns.TourLand
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="TourLandDomainServiceBase"/>.
    /// For application services inherit TourLandAppServiceBase.
    /// </summary>
    public abstract class TourLandServiceBase : AbpServiceBase
    {
        protected TourLandServiceBase()
        {
            LocalizationSourceName = TourLandConsts.LocalizationSourceName;
        }
    }
}