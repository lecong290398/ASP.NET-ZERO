using Abp.Application.Navigation;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Views.Shared.Components.AppAreaLeCongMenu
{
    public class UserMenuItemViewModel
    {
        public UserMenuItem MenuItem { get; set; }

        public string CurrentPageName { get; set; }

        public int MenuItemIndex { get; set; }

        public int ItemDepth { get; set; }

        public bool RootLevel { get; set; }
        
        public bool IsTabMenuUsed { get; set; }
    }
}
