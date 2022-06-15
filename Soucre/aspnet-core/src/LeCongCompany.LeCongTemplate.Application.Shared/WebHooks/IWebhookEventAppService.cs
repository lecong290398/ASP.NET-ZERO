using System.Threading.Tasks;
using Abp.Webhooks;

namespace LeCongCompany.LeCongTemplate.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
