using Abp.AutoMapper;
using LeCong.AbpZeroTemplate.Sessions.Dto;

namespace LeCong.AbpZeroTemplate.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}