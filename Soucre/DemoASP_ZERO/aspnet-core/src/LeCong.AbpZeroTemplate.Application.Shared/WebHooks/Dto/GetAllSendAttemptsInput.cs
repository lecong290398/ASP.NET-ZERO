using LeCong.AbpZeroTemplate.Dto;

namespace LeCong.AbpZeroTemplate.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
