using System.Threading.Tasks;
using LeCong.AbpZeroTemplate.Authorization.Users;

namespace LeCong.AbpZeroTemplate.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
