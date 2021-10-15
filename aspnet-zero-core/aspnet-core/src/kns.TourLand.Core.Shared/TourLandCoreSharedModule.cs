using Abp.Modules;
using Abp.Reflection.Extensions;

namespace kns.TourLand
{
    public class TourLandCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TourLandCoreSharedModule).GetAssembly());
        }
    }
}