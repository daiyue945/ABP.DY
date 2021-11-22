using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP.DY.Authorization;

namespace ABP.DY
{
    [DependsOn(
        typeof(DYCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DYApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DYAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DYApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
