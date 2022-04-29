using System.Threading.Tasks;
using Abp.Application.Services;
using LeCong.AbpZeroTemplate.MultiTenancy.Payments.Dto;
using LeCong.AbpZeroTemplate.MultiTenancy.Payments.Stripe.Dto;

namespace LeCong.AbpZeroTemplate.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}