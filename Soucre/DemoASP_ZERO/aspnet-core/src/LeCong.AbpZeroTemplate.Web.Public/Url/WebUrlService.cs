using Abp.Dependency;
using LeCong.AbpZeroTemplate.Configuration;
using LeCong.AbpZeroTemplate.Url;
using LeCong.AbpZeroTemplate.Web.Url;

namespace LeCong.AbpZeroTemplate.Web.Public.Url
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