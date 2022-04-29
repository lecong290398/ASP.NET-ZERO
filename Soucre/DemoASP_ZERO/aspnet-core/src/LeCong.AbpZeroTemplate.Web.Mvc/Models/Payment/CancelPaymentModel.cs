using LeCong.AbpZeroTemplate.MultiTenancy.Payments;

namespace LeCong.AbpZeroTemplate.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}