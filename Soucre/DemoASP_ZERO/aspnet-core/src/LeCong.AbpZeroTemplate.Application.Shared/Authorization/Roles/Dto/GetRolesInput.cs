using System.Collections.Generic;

namespace LeCong.AbpZeroTemplate.Authorization.Roles.Dto
{
    public class GetRolesInput
    {
        public List<string> Permissions { get; set; }
    }
}
