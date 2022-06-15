using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using LeCongCompany.LeCongTemplate.Authorization;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Editions;
using LeCongCompany.LeCongTemplate.Web.Controllers;
using LeCongCompany.LeCongTemplate.Web.Session;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Controllers
{
    [Area("AppAreaLeCong")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement)]
    public class SubscriptionManagementController : LeCongTemplateControllerBase
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public SubscriptionManagementController(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<ActionResult> Index()
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            var model = new SubscriptionDashboardViewModel
            {
                LoginInformations = loginInfo
            };

            return View(model);
        }
    }
}