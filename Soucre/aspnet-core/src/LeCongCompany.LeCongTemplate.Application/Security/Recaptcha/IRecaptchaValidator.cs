using System.Threading.Tasks;

namespace LeCongCompany.LeCongTemplate.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}