using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LeCongCompany.LeCongTemplate.Authorization;

namespace LeCongCompany.LeCongTemplate
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(LeCongTemplateApplicationSharedModule),
        typeof(LeCongTemplateCoreModule)
        )]
    public class LeCongTemplateApplicationModule : AbpModule
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
            IocManager.RegisterAssemblyByConvention(typeof(LeCongTemplateApplicationModule).GetAssembly());
        }
    }
}