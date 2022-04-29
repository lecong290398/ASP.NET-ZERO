using System.Collections.Generic;
using LeCong.AbpZeroTemplate.DashboardCustomization.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.CustomizableDashboard
{
    public class AddWidgetViewModel
    {
        public List<WidgetOutput> Widgets { get; set; }

        public string DashboardName { get; set; }

        public string PageId { get; set; }
    }
}
