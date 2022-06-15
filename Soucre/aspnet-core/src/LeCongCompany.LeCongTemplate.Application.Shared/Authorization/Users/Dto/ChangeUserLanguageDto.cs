using System.ComponentModel.DataAnnotations;

namespace LeCongCompany.LeCongTemplate.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
