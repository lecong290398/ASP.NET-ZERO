using Abp.Events.Bus;

namespace LeCongCompany.LeCongTemplate.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}