using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.Editions.Dto;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Common;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Editions
{
    [AutoMapFrom(typeof(GetEditionEditOutput))]
    public class CreateEditionModalViewModel : GetEditionEditOutput, IFeatureEditViewModel
    {
        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public IReadOnlyList<ComboboxItemDto> FreeEditionItems { get; set; }
    }
}