using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Authorization.Permissions.Dto;

namespace LeCong.AbpZeroTemplate.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}