using Abp.Modules;
using Abp.Reflection.Extensions;

namespace LeCong.AbpZeroTemplate
{
    public class AbpZeroTemplateCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroTemplateCoreSharedModule).GetAssembly());
        }
    }
}