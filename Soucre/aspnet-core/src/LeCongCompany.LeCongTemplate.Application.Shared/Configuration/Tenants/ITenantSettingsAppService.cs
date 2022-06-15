using System.Threading.Tasks;
using Abp.Application.Services;
using LeCongCompany.LeCongTemplate.Configuration.Tenants.Dto;

namespace LeCongCompany.LeCongTemplate.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
