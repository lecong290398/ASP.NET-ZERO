using System.Collections.Generic;
using Abp.Localization;
using LeCongCompany.LeCongTemplate.Install.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
