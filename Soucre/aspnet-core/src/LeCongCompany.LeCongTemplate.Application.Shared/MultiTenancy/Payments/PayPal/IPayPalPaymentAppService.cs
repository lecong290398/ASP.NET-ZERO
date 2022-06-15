using System.Threading.Tasks;
using Abp.Application.Services;
using LeCongCompany.LeCongTemplate.MultiTenancy.Payments.PayPal.Dto;

namespace LeCongCompany.LeCongTemplate.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
