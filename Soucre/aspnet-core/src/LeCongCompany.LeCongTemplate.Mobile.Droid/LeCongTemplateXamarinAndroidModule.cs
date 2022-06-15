using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LeCongCompany.LeCongTemplate
{
    [DependsOn(typeof(LeCongTemplateXamarinSharedModule))]
    public class LeCongTemplateXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LeCongTemplateXamarinAndroidModule).GetAssembly());
        }
    }
}