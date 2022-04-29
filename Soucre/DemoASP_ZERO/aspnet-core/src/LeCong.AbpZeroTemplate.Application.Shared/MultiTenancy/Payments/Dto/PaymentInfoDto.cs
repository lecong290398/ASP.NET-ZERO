using LeCong.AbpZeroTemplate.Editions.Dto;

namespace LeCong.AbpZeroTemplate.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < AbpZeroTemplateConsts.MinimumUpgradePaymentAmount;
        }
    }
}
