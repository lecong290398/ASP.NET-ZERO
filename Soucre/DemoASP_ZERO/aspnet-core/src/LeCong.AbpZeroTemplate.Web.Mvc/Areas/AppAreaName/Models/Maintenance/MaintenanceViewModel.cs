using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Caching.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}