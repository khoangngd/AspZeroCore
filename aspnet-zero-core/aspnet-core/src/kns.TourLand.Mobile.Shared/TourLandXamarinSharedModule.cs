using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace kns.TourLand
{
    [DependsOn(typeof(TourLandClientModule), typeof(AbpAutoMapperModule))]
    public class TourLandXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TourLandXamarinSharedModule).GetAssembly());
        }
    }
}