using Microsoft.AspNetCore.Mvc;
using LeCongCompany.LeCongTemplate.Web.Controllers;

namespace LeCongCompany.LeCongTemplate.Web.Public.Controllers
{
    public class AboutController : LeCongTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}