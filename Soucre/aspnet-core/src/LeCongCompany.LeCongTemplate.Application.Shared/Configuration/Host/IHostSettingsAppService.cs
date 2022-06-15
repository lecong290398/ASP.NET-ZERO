using System.Threading.Tasks;
using Abp.Application.Services;
using LeCongCompany.LeCongTemplate.Configuration.Host.Dto;

namespace LeCongCompany.LeCongTemplate.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
