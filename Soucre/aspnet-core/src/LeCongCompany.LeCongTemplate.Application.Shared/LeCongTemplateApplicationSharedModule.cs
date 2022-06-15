using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LeCongCompany.LeCongTemplate
{
    [DependsOn(typeof(LeCongTemplateCoreSharedModule))]
    public class LeCongTemplateApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LeCongTemplateApplicationSharedModule).GetAssembly());
        }
    }
}