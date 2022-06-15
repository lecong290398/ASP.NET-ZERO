using System.Threading.Tasks;
using LeCongCompany.LeCongTemplate.Security.Recaptcha;

namespace LeCongCompany.LeCongTemplate.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
