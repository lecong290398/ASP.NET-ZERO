using System.ComponentModel.DataAnnotations;

namespace LeCongCompany.LeCongTemplate.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}