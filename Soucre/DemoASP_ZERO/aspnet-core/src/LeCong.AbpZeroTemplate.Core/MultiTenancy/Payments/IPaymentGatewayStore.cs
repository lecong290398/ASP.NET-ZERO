using System.Collections.Generic;

namespace LeCong.AbpZeroTemplate.MultiTenancy.Payments
{
    public interface IPaymentGatewayStore
    {
        List<PaymentGatewayModel> GetActiveGateways();
    }
}
