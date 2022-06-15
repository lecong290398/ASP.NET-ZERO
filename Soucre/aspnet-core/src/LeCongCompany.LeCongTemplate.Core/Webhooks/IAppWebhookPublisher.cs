using System.Threading.Tasks;
using LeCongCompany.LeCongTemplate.Authorization.Users;

namespace LeCongCompany.LeCongTemplate.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
