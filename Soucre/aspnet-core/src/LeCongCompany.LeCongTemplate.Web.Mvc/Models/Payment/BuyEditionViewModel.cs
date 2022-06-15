using System.Collections.Generic;
using LeCongCompany.LeCongTemplate.Editions;
using LeCongCompany.LeCongTemplate.Editions.Dto;
using LeCongCompany.LeCongTemplate.MultiTenancy.Payments;
using LeCongCompany.LeCongTemplate.MultiTenancy.Payments.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
