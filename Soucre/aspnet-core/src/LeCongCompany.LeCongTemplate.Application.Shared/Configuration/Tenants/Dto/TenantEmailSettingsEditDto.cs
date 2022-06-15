using Abp.Auditing;
using LeCongCompany.LeCongTemplate.Configuration.Dto;

namespace LeCongCompany.LeCongTemplate.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}