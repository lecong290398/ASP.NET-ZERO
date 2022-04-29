using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Authorization.Permissions.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}