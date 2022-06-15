using System.ComponentModel.DataAnnotations;

namespace LeCongCompany.LeCongTemplate.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}