using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using LeCongCompany.LeCongTemplate.MultiTenancy.Accounting;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Accounting;
using LeCongCompany.LeCongTemplate.Web.Controllers;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Controllers
{
    [Area("AppAreaLeCong")]
    public class InvoiceController : LeCongTemplateControllerBase
    {
        private readonly IInvoiceAppService _invoiceAppService;

        public InvoiceController(IInvoiceAppService invoiceAppService)
        {
            _invoiceAppService = invoiceAppService;
        }


        [HttpGet]
        public async Task<ActionResult> Index(long paymentId)
        {
            var invoice = await _invoiceAppService.GetInvoiceInfo(new EntityDto<long>(paymentId));
            var model = new InvoiceViewModel
            {
                Invoice = invoice
            };

            return View(model);
        }
    }
}