using Abp.Application.Services;
using LeCongCompany.LeCongTemplate.Dto;
using LeCongCompany.LeCongTemplate.Logging.Dto;

namespace LeCongCompany.LeCongTemplate.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
