using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Editions.Dto;
using LeCong.AbpZeroTemplate.MultiTenancy.Payments;

namespace LeCong.AbpZeroTemplate.Web.Models.Payment
{
    public class UpgradeEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public PaymentPeriodType PaymentPeriodType { get; set; }

        public SubscriptionPaymentType SubscriptionPaymentType { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}