using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using tls.demo.Configure;
using tls.demo.Startup;
using tls.demo.Test.Base;

namespace tls.demo.GraphQL.Tests
{
    [DependsOn(
        typeof(demoGraphQLModule),
        typeof(demoTestBaseModule))]
    public class demoGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(demoGraphQLTestModule).GetAssembly());
        }
    }
}