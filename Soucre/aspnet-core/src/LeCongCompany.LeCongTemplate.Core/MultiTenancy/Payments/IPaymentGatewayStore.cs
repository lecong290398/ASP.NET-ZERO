using System.Collections.Generic;

namespace LeCongCompany.LeCongTemplate.MultiTenancy.Payments
{
    public interface IPaymentGatewayStore
    {
        List<PaymentGatewayModel> GetActiveGateways();
    }
}
