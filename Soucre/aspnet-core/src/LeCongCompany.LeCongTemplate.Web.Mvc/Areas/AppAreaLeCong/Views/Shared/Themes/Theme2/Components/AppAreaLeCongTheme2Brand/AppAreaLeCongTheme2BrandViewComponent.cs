using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Layout;
using LeCongCompany.LeCongTemplate.Web.Session;
using LeCongCompany.LeCongTemplate.Web.Views;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Views.Shared.Themes.Theme2.Components.AppAreaLeCongTheme2Brand
{
    public class AppAreaLeCongTheme2BrandViewComponent : LeCongTemplateViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaLeCongTheme2BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
