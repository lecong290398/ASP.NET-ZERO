using Microsoft.AspNetCore.Mvc;
using LeCong.AbpZeroTemplate.Web.Controllers;

namespace LeCong.AbpZeroTemplate.Web.Public.Controllers
{
    public class HomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}