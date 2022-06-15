using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Layout;
using LeCongCompany.LeCongTemplate.Web.Session;
using LeCongCompany.LeCongTemplate.Web.Views;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Views.Shared.Themes.Theme4.Components.AppAreaLeCongTheme4Footer
{
    public class AppAreaLeCongTheme4FooterViewComponent : LeCongTemplateViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaLeCongTheme4FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
