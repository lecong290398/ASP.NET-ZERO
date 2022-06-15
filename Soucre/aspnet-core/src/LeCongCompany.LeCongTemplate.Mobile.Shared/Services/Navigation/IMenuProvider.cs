using System.Collections.Generic;
using MvvmHelpers;
using LeCongCompany.LeCongTemplate.Models.NavigationMenu;

namespace LeCongCompany.LeCongTemplate.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}