using System.Collections.Generic;
using Abp.Application.Services.Dto;
using LeCongCompany.LeCongTemplate.Editions.Dto;

namespace LeCongCompany.LeCongTemplate.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}