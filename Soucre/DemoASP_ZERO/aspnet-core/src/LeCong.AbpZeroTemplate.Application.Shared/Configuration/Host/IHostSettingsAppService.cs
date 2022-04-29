using System.Threading.Tasks;
using Abp.Application.Services;
using LeCong.AbpZeroTemplate.Configuration.Host.Dto;

namespace LeCong.AbpZeroTemplate.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
