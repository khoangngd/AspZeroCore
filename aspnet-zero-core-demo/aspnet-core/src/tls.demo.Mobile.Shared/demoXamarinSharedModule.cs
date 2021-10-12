using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace tls.demo
{
    [DependsOn(typeof(demoClientModule), typeof(AbpAutoMapperModule))]
    public class demoXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(demoXamarinSharedModule).GetAssembly());
        }
    }
}