using Abp.Application.Services;
using LeCong.AbpZeroTemplate.Dto;
using LeCong.AbpZeroTemplate.Logging.Dto;

namespace LeCong.AbpZeroTemplate.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
