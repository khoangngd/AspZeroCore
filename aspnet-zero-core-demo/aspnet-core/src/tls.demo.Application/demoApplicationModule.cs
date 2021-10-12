using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using tls.demo.Authorization;

namespace tls.demo
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(demoApplicationSharedModule),
        typeof(demoCoreModule)
        )]
    public class demoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(demoApplicationModule).GetAssembly());
        }
    }
}