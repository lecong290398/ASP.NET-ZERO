using Abp.Application.Navigation;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Layout
{
    public class MenuViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; }
    }
}