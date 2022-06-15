using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using LeCongCompany.LeCongTemplate.Authorization;
using LeCongCompany.LeCongTemplate.DashboardCustomization;
using System.Threading.Tasks;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Startup;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Controllers
{
    [Area("AppAreaLeCong")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(LeCongTemplateDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}