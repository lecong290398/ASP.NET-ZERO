using Abp.Authorization;
using LeCong.AbpZeroTemplate.Authorization.Roles;
using LeCong.AbpZeroTemplate.Authorization.Users;

namespace LeCong.AbpZeroTemplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
