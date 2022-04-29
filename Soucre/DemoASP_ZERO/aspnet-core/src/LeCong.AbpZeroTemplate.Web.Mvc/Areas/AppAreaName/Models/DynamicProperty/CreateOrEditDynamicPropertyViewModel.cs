using System.Collections.Generic;
using LeCong.AbpZeroTemplate.DynamicEntityProperties.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
