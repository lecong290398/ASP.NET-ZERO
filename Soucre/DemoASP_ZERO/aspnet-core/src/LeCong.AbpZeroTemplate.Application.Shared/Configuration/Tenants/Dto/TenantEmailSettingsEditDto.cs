using Abp.Auditing;
using LeCong.AbpZeroTemplate.Configuration.Dto;

namespace LeCong.AbpZeroTemplate.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}