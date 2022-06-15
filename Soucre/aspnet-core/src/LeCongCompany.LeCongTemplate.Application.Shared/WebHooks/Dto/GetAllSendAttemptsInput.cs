using LeCongCompany.LeCongTemplate.Dto;

namespace LeCongCompany.LeCongTemplate.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
