using Abp.Dependency;
using LeCongCompany.LeCongTemplate.Configuration;
using LeCongCompany.LeCongTemplate.Url;
using LeCongCompany.LeCongTemplate.Web.Url;

namespace LeCongCompany.LeCongTemplate.Web.Public.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor appConfigurationAccessor) :
            base(appConfigurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

        public override string ServerRootAddressFormatKey => "App:AdminWebSiteRootAddress";
    }
}