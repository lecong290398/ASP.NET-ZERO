using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace LeCongCompany.LeCongTemplate.Web.Public.Views
{
    public abstract class LeCongTemplateRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LeCongTemplateRazorPage()
        {
            LocalizationSourceName = LeCongTemplateConsts.LocalizationSourceName;
        }
    }
}
