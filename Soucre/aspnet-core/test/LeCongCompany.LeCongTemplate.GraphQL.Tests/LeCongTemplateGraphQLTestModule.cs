using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using LeCongCompany.LeCongTemplate.Configure;
using LeCongCompany.LeCongTemplate.Startup;
using LeCongCompany.LeCongTemplate.Test.Base;

namespace LeCongCompany.LeCongTemplate.GraphQL.Tests
{
    [DependsOn(
        typeof(LeCongTemplateGraphQLModule),
        typeof(LeCongTemplateTestBaseModule))]
    public class LeCongTemplateGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LeCongTemplateGraphQLTestModule).GetAssembly());
        }
    }
}