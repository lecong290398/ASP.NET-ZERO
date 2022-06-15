using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LeCongCompany.LeCongTemplate
{
    public class LeCongTemplateCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LeCongTemplateCoreSharedModule).GetAssembly());
        }
    }
}