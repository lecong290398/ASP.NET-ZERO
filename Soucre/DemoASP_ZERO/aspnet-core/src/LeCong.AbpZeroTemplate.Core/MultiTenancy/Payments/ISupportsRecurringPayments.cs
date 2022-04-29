using Abp.Events.Bus.Handlers;

namespace LeCong.AbpZeroTemplate.MultiTenancy.Payments
{
    public interface ISupportsRecurringPayments : 
        IEventHandler<RecurringPaymentsDisabledEventData>, 
        IEventHandler<RecurringPaymentsEnabledEventData>,
        IEventHandler<TenantEditionChangedEventData>
    {

    }
}
