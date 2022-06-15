using Microsoft.AspNetCore.Antiforgery;

namespace LeCongCompany.LeCongTemplate.Web.Controllers
{
    public class AntiForgeryController : LeCongTemplateControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
