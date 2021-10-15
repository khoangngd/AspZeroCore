using Abp.Modules;
using Abp.Reflection.Extensions;

namespace kns.TourLand
{
    [DependsOn(typeof(TourLandXamarinSharedModule))]
    public class TourLandXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TourLandXamarinIosModule).GetAssembly());
        }
    }
}