using Abp.Modules;
using Abp.Reflection.Extensions;

namespace tls.demo
{
    public class demoClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(demoClientModule).GetAssembly());
        }
    }
}
