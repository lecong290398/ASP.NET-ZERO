using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.Sessions.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}