using Abp.Modules;
using Abp.Reflection.Extensions;

namespace tls.demo
{
    [DependsOn(typeof(demoXamarinSharedModule))]
    public class demoXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(demoXamarinAndroidModule).GetAssembly());
        }
    }
}