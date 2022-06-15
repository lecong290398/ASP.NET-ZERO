using System.Threading.Tasks;
using Abp.Application.Services;
using LeCongCompany.LeCongTemplate.Install.Dto;

namespace LeCongCompany.LeCongTemplate.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}