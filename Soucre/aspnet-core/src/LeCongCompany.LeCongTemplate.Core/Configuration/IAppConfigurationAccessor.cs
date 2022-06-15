using Microsoft.Extensions.Configuration;

namespace LeCongCompany.LeCongTemplate.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
