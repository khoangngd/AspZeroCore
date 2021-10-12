using Abp.Modules;
using tls.demo.Test.Base;

namespace tls.demo.Tests
{
    [DependsOn(typeof(demoTestBaseModule))]
    public class demoTestModule : AbpModule
    {
       
    }
}
