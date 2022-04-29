using System.Collections.Generic;
using Abp.Localization;
using LeCong.AbpZeroTemplate.Install.Dto;

namespace LeCong.AbpZeroTemplate.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
