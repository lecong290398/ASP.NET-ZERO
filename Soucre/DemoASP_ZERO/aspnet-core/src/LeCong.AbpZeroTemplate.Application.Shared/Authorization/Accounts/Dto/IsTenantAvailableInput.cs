using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace LeCong.AbpZeroTemplate.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [MaxLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}