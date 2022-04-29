using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Editions;
using LeCong.AbpZeroTemplate.Editions.Dto;
using LeCong.AbpZeroTemplate.MultiTenancy.Payments;
using LeCong.AbpZeroTemplate.MultiTenancy.Payments.Dto;

namespace LeCong.AbpZeroTemplate.Web.Models.Payment
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
