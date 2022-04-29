using Abp.AutoMapper;
using LeCong.AbpZeroTemplate.MultiTenancy;
using LeCong.AbpZeroTemplate.MultiTenancy.Dto;
using LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}