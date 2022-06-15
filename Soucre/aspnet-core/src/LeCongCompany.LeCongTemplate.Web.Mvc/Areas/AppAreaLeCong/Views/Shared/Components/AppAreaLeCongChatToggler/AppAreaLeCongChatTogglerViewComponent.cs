using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Layout;
using LeCongCompany.LeCongTemplate.Web.Views;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Views.Shared.Components.AppAreaLeCongChatToggler
{
    public class AppAreaLeCongChatTogglerViewComponent : LeCongTemplateViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            return Task.FromResult<IViewComponentResult>(View(new ChatTogglerViewModel
            {
                CssClass = cssClass
            }));
        }
    }
}
