using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Layout;
using LeCong.AbpZeroTemplate.Web.Views;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Views.Shared.Components.
    AppAreaNameQuickThemeSelect
{
    public class AppAreaNameQuickThemeSelectViewComponent : AbpZeroTemplateViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            return Task.FromResult<IViewComponentResult>(View(new QuickThemeSelectionViewModel
            {
                CssClass = cssClass
            }));
        }
    }
}
