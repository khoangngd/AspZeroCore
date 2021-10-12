using Abp.Modules;
using Abp.Reflection.Extensions;

namespace tls.demo
{
    [DependsOn(typeof(demoXamarinSharedModule))]
    public class demoXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(demoXamarinIosModule).GetAssembly());
        }
    }
}