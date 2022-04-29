using System.Collections.Generic;
using Abp.Application.Services.Dto;
using LeCong.AbpZeroTemplate.Configuration.Host.Dto;
using LeCong.AbpZeroTemplate.Editions.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }

        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}