using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeCongCompany.LeCongTemplate.Authorization.Permissions.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Common.Modals
{
    public class PermissionTreeModalViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }
        public List<string> GrantedPermissionNames { get; set; }
    }
}
