using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LeCongCompany.LeCongTemplate
{
    [DependsOn(typeof(LeCongTemplateClientModule), typeof(AbpAutoMapperModule))]
    public class LeCongTemplateXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LeCongTemplateXamarinSharedModule).GetAssembly());
        }
    }
}