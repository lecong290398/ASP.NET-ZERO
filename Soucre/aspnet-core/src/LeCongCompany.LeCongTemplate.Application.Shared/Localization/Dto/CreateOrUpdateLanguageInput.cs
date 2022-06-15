using System.ComponentModel.DataAnnotations;

namespace LeCongCompany.LeCongTemplate.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}