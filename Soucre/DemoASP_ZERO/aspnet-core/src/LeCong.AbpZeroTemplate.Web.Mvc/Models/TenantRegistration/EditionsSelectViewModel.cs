using Abp.AutoMapper;
using LeCong.AbpZeroTemplate.MultiTenancy.Dto;

namespace LeCong.AbpZeroTemplate.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
