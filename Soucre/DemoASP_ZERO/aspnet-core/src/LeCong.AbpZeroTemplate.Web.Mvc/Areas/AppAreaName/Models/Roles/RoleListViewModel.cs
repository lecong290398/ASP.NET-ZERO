using System.Collections.Generic;
using Abp.Application.Services.Dto;
using LeCong.AbpZeroTemplate.Authorization.Permissions.Dto;
using LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}