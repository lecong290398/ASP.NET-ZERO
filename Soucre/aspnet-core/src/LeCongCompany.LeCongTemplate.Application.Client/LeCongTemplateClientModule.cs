using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LeCongCompany.LeCongTemplate
{
    public class LeCongTemplateClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LeCongTemplateClientModule).GetAssembly());
        }
    }
}
