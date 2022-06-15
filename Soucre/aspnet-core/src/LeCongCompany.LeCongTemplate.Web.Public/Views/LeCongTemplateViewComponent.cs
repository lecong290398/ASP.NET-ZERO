using Abp.AspNetCore.Mvc.ViewComponents;

namespace LeCongCompany.LeCongTemplate.Web.Public.Views
{
    public abstract class LeCongTemplateViewComponent : AbpViewComponent
    {
        protected LeCongTemplateViewComponent()
        {
            LocalizationSourceName = LeCongTemplateConsts.LocalizationSourceName;
        }
    }
}