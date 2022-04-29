using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeCong.AbpZeroTemplate.Authorization.Permissions.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common.Modals
{
    public class PermissionTreeModalViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }
        public List<string> GrantedPermissionNames { get; set; }
    }
}
