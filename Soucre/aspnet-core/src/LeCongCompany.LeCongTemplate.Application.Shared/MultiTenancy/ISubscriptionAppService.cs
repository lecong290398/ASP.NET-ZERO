using System.Threading.Tasks;
using Abp.Application.Services;

namespace LeCongCompany.LeCongTemplate.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
