using System.Collections.Generic;
using Abp.Application.Services.Dto;
using LeCong.AbpZeroTemplate.Configuration.Tenants.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
        
        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}