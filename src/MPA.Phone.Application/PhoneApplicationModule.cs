using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MPA.Phone.Authorization;

namespace MPA.Phone
{
    [DependsOn(
        typeof(PhoneCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PhoneApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PhoneAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PhoneApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
