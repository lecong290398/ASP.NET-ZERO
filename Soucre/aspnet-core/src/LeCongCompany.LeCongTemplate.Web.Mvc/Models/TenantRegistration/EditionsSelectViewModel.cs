using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.MultiTenancy.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
