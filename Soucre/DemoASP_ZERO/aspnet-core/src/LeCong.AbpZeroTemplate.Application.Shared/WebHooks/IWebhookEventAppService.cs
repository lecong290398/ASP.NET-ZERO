using System.Threading.Tasks;
using Abp.Webhooks;

namespace LeCong.AbpZeroTemplate.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
