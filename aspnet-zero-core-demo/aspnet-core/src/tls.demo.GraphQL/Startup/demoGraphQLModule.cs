using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace tls.demo.Startup
{
    [DependsOn(typeof(demoCoreModule))]
    public class demoGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(demoGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}