using System.Threading.Tasks;
using Abp.Application.Services;
using LeCong.AbpZeroTemplate.Configuration.Tenants.Dto;

namespace LeCong.AbpZeroTemplate.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
