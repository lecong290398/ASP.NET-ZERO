using System.Collections.Generic;
using Abp.Application.Services.Dto;
using LeCong.AbpZeroTemplate.Authorization.Permissions.Dto;
using LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Users
{
    public class UsersViewModel : IPermissionsEditViewModel
    {
        public string FilterText { get; set; }

        public List<ComboboxItemDto> Roles { get; set; }

        public bool OnlyLockedUsers { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}
