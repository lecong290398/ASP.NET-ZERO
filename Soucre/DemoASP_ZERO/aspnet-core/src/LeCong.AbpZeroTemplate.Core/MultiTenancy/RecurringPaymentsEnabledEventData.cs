using Abp.Events.Bus;

namespace LeCong.AbpZeroTemplate.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}