using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LeCong.AbpZeroTemplate
{
    [DependsOn(typeof(AbpZeroTemplateCoreSharedModule))]
    public class AbpZeroTemplateApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroTemplateApplicationSharedModule).GetAssembly());
        }
    }
}