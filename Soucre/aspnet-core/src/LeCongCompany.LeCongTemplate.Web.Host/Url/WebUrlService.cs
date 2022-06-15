using Abp.Dependency;
using LeCongCompany.LeCongTemplate.Configuration;
using LeCongCompany.LeCongTemplate.Url;

namespace LeCongCompany.LeCongTemplate.Web.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor configurationAccessor) :
            base(configurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:ClientRootAddress";

        public override string ServerRootAddressFormatKey => "App:ServerRootAddress";
    }
}