using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using LeCong.AbpZeroTemplate.WebHooks.Dto;

namespace LeCong.AbpZeroTemplate.WebHooks
{
    public interface IWebhookAttemptAppService
    {
        Task<PagedResultDto<GetAllSendAttemptsOutput>> GetAllSendAttempts(GetAllSendAttemptsInput input);

        Task<ListResultDto<GetAllSendAttemptsOfWebhookEventOutput>> GetAllSendAttemptsOfWebhookEvent(GetAllSendAttemptsOfWebhookEventInput input);
    }
}
