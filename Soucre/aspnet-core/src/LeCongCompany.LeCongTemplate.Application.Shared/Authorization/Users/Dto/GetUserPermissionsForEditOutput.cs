using System.Collections.Generic;
using LeCongCompany.LeCongTemplate.Authorization.Permissions.Dto;

namespace LeCongCompany.LeCongTemplate.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}