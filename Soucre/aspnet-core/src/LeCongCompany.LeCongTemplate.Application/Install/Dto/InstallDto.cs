using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using LeCongCompany.LeCongTemplate.Configuration.Dto;
using LeCongCompany.LeCongTemplate.Configuration.Host.Dto;

namespace LeCongCompany.LeCongTemplate.Install.Dto
{
    public class InstallDto
    {
        [Required]
        [DisableAuditing]
        public string ConnectionString { get; set; }

        [Required]
        [DisableAuditing]
        public string AdminPassword { get; set; }

        [Required]
        public string WebSiteUrl { get; set; }

        public string ServerUrl { get; set; }

        [Required]
        public string DefaultLanguage { get; set; }

        public EmailSettingsEditDto SmtpSettings { get; set; }

        public HostBillingSettingsEditDto BillInfo { get; set; }
    }
}