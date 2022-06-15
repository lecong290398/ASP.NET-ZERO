using Microsoft.Extensions.DependencyInjection;
using LeCongCompany.LeCongTemplate.HealthChecks;

namespace LeCongCompany.LeCongTemplate.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<LeCongTemplateDbContextHealthCheck>("Database Connection");
            builder.AddCheck<LeCongTemplateDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
