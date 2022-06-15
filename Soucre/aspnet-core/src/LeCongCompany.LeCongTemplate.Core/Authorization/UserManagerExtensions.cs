using System.Threading.Tasks;
using Abp.Authorization.Users;
using LeCongCompany.LeCongTemplate.Authorization.Users;

namespace LeCongCompany.LeCongTemplate.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}
