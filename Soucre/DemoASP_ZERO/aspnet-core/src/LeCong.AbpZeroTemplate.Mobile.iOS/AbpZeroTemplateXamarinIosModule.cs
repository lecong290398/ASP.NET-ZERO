using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LeCong.AbpZeroTemplate
{
    [DependsOn(typeof(AbpZeroTemplateXamarinSharedModule))]
    public class AbpZeroTemplateXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroTemplateXamarinIosModule).GetAssembly());
        }
    }
}