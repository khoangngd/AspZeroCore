using Abp.Modules;
using Abp.Reflection.Extensions;

namespace kns.TourLand
{
    [DependsOn(typeof(TourLandCoreSharedModule))]
    public class TourLandApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TourLandApplicationSharedModule).GetAssembly());
        }
    }
}