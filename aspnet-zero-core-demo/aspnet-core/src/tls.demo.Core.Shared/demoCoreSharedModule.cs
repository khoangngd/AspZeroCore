using Abp.Modules;
using Abp.Reflection.Extensions;

namespace tls.demo
{
    public class demoCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(demoCoreSharedModule).GetAssembly());
        }
    }
}