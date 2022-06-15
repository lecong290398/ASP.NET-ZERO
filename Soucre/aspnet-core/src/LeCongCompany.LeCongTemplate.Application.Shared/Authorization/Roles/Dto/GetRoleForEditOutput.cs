using System.Collections.Generic;
using LeCongCompany.LeCongTemplate.Authorization.Permissions.Dto;

namespace LeCongCompany.LeCongTemplate.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}