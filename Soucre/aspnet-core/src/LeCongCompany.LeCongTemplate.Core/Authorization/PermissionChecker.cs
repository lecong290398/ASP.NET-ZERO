using Abp.Authorization;
using LeCongCompany.LeCongTemplate.Authorization.Roles;
using LeCongCompany.LeCongTemplate.Authorization.Users;

namespace LeCongCompany.LeCongTemplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
