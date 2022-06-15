using System.Collections.Generic;
using LeCongCompany.LeCongTemplate.Editions.Dto;
using LeCongCompany.LeCongTemplate.MultiTenancy.Payments;

namespace LeCongCompany.LeCongTemplate.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}