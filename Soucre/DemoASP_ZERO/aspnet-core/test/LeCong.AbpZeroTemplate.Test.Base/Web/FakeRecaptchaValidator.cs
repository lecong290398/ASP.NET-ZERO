using System.Threading.Tasks;
using LeCong.AbpZeroTemplate.Security.Recaptcha;

namespace LeCong.AbpZeroTemplate.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
