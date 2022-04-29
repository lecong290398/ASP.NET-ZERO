using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using LeCong.AbpZeroTemplate.MultiTenancy.Accounting.Dto;

namespace LeCong.AbpZeroTemplate.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
