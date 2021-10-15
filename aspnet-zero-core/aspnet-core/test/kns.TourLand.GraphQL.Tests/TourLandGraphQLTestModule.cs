using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using kns.TourLand.Configure;
using kns.TourLand.Startup;
using kns.TourLand.Test.Base;

namespace kns.TourLand.GraphQL.Tests
{
    [DependsOn(
        typeof(TourLandGraphQLModule),
        typeof(TourLandTestBaseModule))]
    public class TourLandGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TourLandGraphQLTestModule).GetAssembly());
        }
    }
}