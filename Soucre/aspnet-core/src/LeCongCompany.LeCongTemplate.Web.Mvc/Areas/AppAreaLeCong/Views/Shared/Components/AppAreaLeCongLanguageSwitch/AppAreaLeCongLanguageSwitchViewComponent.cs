using System.Linq;
using System.Threading.Tasks;
using Abp.Localization;
using Microsoft.AspNetCore.Mvc;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Layout;
using LeCongCompany.LeCongTemplate.Web.Views;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Views.Shared.Components.AppAreaLeCongLanguageSwitch
{
    public class AppAreaLeCongLanguageSwitchViewComponent : LeCongTemplateViewComponent
    {
        private readonly ILanguageManager _languageManager;

        public AppAreaLeCongLanguageSwitchViewComponent(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }

        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new LanguageSwitchViewModel
            {
                Languages = _languageManager.GetActiveLanguages().ToList(),
                CurrentLanguage = _languageManager.CurrentLanguage,
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
