using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using LeCongCompany.LeCongTemplate.Configuration;

namespace LeCongCompany.LeCongTemplate.Test.Base.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(LeCongTemplateTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
