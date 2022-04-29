using System.Threading.Tasks;
using Abp.Application.Services;
using LeCong.AbpZeroTemplate.Install.Dto;

namespace LeCong.AbpZeroTemplate.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}