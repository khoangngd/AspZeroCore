using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using kns.TourLand.Authorization;

namespace kns.TourLand
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(TourLandApplicationSharedModule),
        typeof(TourLandCoreModule)
        )]
    public class TourLandApplicationModule : AbpModule
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
            IocManager.RegisterAssemblyByConvention(typeof(TourLandApplicationModule).GetAssembly());
        }
    }
}