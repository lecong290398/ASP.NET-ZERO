using System.Collections.Generic;

namespace LeCongCompany.LeCongTemplate.Configuration.Dto
{
    public class ExternalLoginSettingsDto
    {
        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}