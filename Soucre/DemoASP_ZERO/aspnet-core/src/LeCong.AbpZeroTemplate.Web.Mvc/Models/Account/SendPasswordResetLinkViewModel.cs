using System.ComponentModel.DataAnnotations;

namespace LeCong.AbpZeroTemplate.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}