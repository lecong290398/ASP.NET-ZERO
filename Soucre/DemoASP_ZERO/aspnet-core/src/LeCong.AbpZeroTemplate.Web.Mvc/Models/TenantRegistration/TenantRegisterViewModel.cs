using LeCong.AbpZeroTemplate.Editions;
using LeCong.AbpZeroTemplate.Editions.Dto;
using LeCong.AbpZeroTemplate.MultiTenancy.Payments;
using LeCong.AbpZeroTemplate.Security;
using LeCong.AbpZeroTemplate.MultiTenancy.Payments.Dto;

namespace LeCong.AbpZeroTemplate.Web.Models.TenantRegistration
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
