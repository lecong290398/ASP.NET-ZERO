using Abp.AspNetCore.Mvc.Views;

namespace LeCongCompany.LeCongTemplate.Web.Views
{
    public abstract class LeCongTemplateRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected LeCongTemplateRazorPage()
        {
            LocalizationSourceName = LeCongTemplateConsts.LocalizationSourceName;
        }
    }
}
