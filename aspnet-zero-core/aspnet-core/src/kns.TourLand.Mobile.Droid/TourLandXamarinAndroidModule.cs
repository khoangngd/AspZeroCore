using Abp.Modules;
using Abp.Reflection.Extensions;

namespace kns.TourLand
{
    [DependsOn(typeof(TourLandXamarinSharedModule))]
    public class TourLandXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TourLandXamarinAndroidModule).GetAssembly());
        }
    }
}