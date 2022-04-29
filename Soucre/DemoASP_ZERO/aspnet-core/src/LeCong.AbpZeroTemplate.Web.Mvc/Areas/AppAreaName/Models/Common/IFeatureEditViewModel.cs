using System.Collections.Generic;
using Abp.Application.Services.Dto;
using LeCong.AbpZeroTemplate.Editions.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}