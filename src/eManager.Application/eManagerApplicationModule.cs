using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using eManager.Authorization;

namespace eManager
{
    [DependsOn(
        typeof(eManagerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class eManagerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<eManagerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(eManagerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
