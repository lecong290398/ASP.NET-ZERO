using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using LeCongCompany.LeCongTemplate.MultiTenancy.Accounting.Dto;

namespace LeCongCompany.LeCongTemplate.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
