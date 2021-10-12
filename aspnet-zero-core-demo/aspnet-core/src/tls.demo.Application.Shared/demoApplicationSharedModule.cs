using Abp.Modules;
using Abp.Reflection.Extensions;

namespace tls.demo
{
    [DependsOn(typeof(demoCoreSharedModule))]
    public class demoApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(demoApplicationSharedModule).GetAssembly());
        }
    }
}