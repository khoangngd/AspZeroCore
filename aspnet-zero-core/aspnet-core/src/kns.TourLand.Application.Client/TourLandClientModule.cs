using Abp.Modules;
using Abp.Reflection.Extensions;

namespace kns.TourLand
{
    public class TourLandClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TourLandClientModule).GetAssembly());
        }
    }
}
