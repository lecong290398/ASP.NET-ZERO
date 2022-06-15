using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LeCongCompany.LeCongTemplate
{
    [DependsOn(typeof(LeCongTemplateXamarinSharedModule))]
    public class LeCongTemplateXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LeCongTemplateXamarinIosModule).GetAssembly());
        }
    }
}