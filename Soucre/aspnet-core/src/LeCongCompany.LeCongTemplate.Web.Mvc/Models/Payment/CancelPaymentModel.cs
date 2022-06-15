using LeCongCompany.LeCongTemplate.MultiTenancy.Payments;

namespace LeCongCompany.LeCongTemplate.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}