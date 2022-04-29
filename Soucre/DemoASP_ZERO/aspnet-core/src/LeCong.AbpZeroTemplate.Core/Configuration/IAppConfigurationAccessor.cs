using Microsoft.Extensions.Configuration;

namespace LeCong.AbpZeroTemplate.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
