﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using LeCongCompany.LeCongTemplate.Configuration.Tenants.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
        
        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}