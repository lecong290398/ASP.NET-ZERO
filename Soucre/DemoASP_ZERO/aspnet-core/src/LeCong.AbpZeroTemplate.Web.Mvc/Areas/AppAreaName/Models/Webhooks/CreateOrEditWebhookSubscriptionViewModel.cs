using Abp.Application.Services.Dto;
using Abp.Webhooks;
using LeCong.AbpZeroTemplate.WebHooks.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
