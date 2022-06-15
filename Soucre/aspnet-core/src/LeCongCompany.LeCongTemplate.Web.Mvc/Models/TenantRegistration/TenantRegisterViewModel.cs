using LeCongCompany.LeCongTemplate.Editions;
using LeCongCompany.LeCongTemplate.Editions.Dto;
using LeCongCompany.LeCongTemplate.MultiTenancy.Payments;
using LeCongCompany.LeCongTemplate.Security;
using LeCongCompany.LeCongTemplate.MultiTenancy.Payments.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
