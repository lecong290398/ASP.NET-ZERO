using System.Threading.Tasks;
using Abp.Application.Services;
using LeCong.AbpZeroTemplate.MultiTenancy.Payments.PayPal.Dto;

namespace LeCong.AbpZeroTemplate.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
