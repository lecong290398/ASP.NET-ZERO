using System;
using System.IO;
using Abp;
using Abp.AspNetZeroCore;
using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Modules;
using Abp.Net.Mail;
using Abp.TestBase;
using Abp.Zero.Configuration;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using LeCongCompany.LeCongTemplate.Authorization.Users;
using LeCongCompany.LeCongTemplate.Configuration;
using LeCongCompany.LeCongTemplate.EntityFrameworkCore;
using LeCongCompany.LeCongTemplate.MultiTenancy;
using LeCongCompany.LeCongTemplate.Security.Recaptcha;
using LeCongCompany.LeCongTemplate.Test.Base.DependencyInjection;
using LeCongCompany.LeCongTemplate.Test.Base.UiCustomization;
using LeCongCompany.LeCongTemplate.Test.Base.Url;
using LeCongCompany.LeCongTemplate.Test.Base.Web;
using LeCongCompany.LeCongTemplate.UiCustomization;
using LeCongCompany.LeCongTemplate.Url;
using NSubstitute;

namespace LeCongCompany.LeCongTemplate.Test.Base
{
    [DependsOn(
        typeof(LeCongTemplateApplicationModule),
        typeof(LeCongTemplateEntityFrameworkCoreModule),
        typeof(AbpTestBaseModule))]
    public class LeCongTemplateTestBaseModule : AbpModule
    {
        public LeCongTemplateTestBaseModule(LeCongTemplateEntityFrameworkCoreModule abpZeroTemplateEntityFrameworkCoreModule)
        {
            abpZeroTemplateEntityFrameworkCoreModule.SkipDbContextRegistration = true;
        }

        public override void PreInitialize()
        {
            var configuration = GetConfiguration();

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            Configuration.UnitOfWork.Timeout = TimeSpan.FromMinutes(30);
            Configuration.UnitOfWork.IsTransactional = false;

            //Disable static mapper usage since it breaks unit tests (see https://github.com/aspnetboilerplate/aspnetboilerplate/issues/2052)
            Configuration.Modules.AbpAutoMapper().UseStaticMapper = false;

            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            RegisterFakeService<AbpZeroDbMigrator>();

            IocManager.Register<IAppUrlService, FakeAppUrlService>();
            IocManager.Register<IWebUrlService, FakeWebUrlService>();
            IocManager.Register<IRecaptchaValidator, FakeRecaptchaValidator>();

            Configuration.ReplaceService<IAppConfigurationAccessor, TestAppConfigurationAccessor>();
            Configuration.ReplaceService<IEmailSender, NullEmailSender>(DependencyLifeStyle.Transient);
            Configuration.ReplaceService<IUiThemeCustomizerFactory, NullUiThemeCustomizerFactory>();

            Configuration.Modules.AspNetZero().LicenseCode = configuration["AbpZeroLicenseCode"];

            //Uncomment below line to write change logs for the entities below:
            Configuration.EntityHistory.IsEnabled = true;
            Configuration.EntityHistory.Selectors.Add("LeCongTemplateEntities", typeof(User), typeof(Tenant));
        }

        public override void Initialize()
        {
            ServiceCollectionRegistrar.Register(IocManager);
        }

        private void RegisterFakeService<TService>()
            where TService : class
        {
            IocManager.IocContainer.Register(
                Component.For<TService>()
                    .UsingFactoryMethod(() => Substitute.For<TService>())
                    .LifestyleSingleton()
            );
        }

        private static IConfigurationRoot GetConfiguration()
        {
            return AppConfigurations.Get(Directory.GetCurrentDirectory(), addUserSecrets: true);
        }
    }
}
