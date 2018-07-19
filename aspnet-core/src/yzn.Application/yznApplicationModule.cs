using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using yzn.Authorization;

namespace yzn
{
    [DependsOn(
        typeof(yznCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class yznApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<yznAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(yznApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
