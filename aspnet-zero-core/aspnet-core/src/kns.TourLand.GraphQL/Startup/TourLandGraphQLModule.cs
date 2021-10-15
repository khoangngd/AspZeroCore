using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace kns.TourLand.Startup
{
    [DependsOn(typeof(TourLandCoreModule))]
    public class TourLandGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TourLandGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}