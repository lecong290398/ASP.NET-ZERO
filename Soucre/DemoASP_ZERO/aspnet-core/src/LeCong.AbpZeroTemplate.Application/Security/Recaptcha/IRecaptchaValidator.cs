using System.Threading.Tasks;

namespace LeCong.AbpZeroTemplate.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}