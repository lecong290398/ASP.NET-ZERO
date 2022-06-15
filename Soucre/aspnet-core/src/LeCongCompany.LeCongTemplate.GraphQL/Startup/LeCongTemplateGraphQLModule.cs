using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LeCongCompany.LeCongTemplate.Startup
{
    [DependsOn(typeof(LeCongTemplateCoreModule))]
    public class LeCongTemplateGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LeCongTemplateGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}