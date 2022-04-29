using System.Collections.Generic;
using MvvmHelpers;
using LeCong.AbpZeroTemplate.Models.NavigationMenu;

namespace LeCong.AbpZeroTemplate.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}