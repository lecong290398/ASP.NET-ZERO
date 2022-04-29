using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Authorization.Permissions.Dto;

namespace LeCong.AbpZeroTemplate.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}