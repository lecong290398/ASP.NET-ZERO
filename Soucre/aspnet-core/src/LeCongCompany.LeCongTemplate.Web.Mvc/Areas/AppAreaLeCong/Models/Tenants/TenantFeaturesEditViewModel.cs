using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.MultiTenancy;
using LeCongCompany.LeCongTemplate.MultiTenancy.Dto;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Common;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}