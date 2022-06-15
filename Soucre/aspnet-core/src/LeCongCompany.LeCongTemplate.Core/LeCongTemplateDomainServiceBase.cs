using Abp.Domain.Services;

namespace LeCongCompany.LeCongTemplate
{
    public abstract class LeCongTemplateDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected LeCongTemplateDomainServiceBase()
        {
            LocalizationSourceName = LeCongTemplateConsts.LocalizationSourceName;
        }
    }
}
