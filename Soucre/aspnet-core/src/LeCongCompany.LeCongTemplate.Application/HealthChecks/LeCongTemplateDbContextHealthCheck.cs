using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using LeCongCompany.LeCongTemplate.EntityFrameworkCore;

namespace LeCongCompany.LeCongTemplate.HealthChecks
{
    public class LeCongTemplateDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public LeCongTemplateDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("LeCongTemplateDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("LeCongTemplateDbContext could not connect to database"));
        }
    }
}
