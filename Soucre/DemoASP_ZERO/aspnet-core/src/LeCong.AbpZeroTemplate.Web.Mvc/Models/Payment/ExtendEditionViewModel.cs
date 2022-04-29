using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Editions.Dto;
using LeCong.AbpZeroTemplate.MultiTenancy.Payments;

namespace LeCong.AbpZeroTemplate.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}