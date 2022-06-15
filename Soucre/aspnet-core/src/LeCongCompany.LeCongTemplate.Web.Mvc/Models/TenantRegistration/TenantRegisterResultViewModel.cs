using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.MultiTenancy.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}