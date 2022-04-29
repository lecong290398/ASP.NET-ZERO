using System.Collections.Generic;
using LeCong.AbpZeroTemplate.DynamicEntityProperties.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.DynamicEntityProperty
{
    public class CreateEntityDynamicPropertyViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicPropertyDto> DynamicProperties { get; set; }
    }
}
