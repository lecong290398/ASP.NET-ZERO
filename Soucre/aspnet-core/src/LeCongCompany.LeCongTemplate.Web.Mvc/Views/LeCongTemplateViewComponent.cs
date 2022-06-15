using Abp.AspNetCore.Mvc.ViewComponents;

namespace LeCongCompany.LeCongTemplate.Web.Views
{
    public abstract class LeCongTemplateViewComponent : AbpViewComponent
    {
        protected LeCongTemplateViewComponent()
        {
            LocalizationSourceName = LeCongTemplateConsts.LocalizationSourceName;
        }
    }
}