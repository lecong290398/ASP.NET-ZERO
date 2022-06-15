using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using LeCongCompany.LeCongTemplate.WebHooks.Dto;

namespace LeCongCompany.LeCongTemplate.WebHooks
{
    public interface IWebhookAttemptAppService
    {
        Task<PagedResultDto<GetAllSendAttemptsOutput>> GetAllSendAttempts(GetAllSendAttemptsInput input);

        Task<ListResultDto<GetAllSendAttemptsOfWebhookEventOutput>> GetAllSendAttemptsOfWebhookEvent(GetAllSendAttemptsOfWebhookEventInput input);
    }
}
