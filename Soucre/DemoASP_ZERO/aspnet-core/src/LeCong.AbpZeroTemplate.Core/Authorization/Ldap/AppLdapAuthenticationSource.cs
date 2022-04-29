using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using LeCong.AbpZeroTemplate.Authorization.Users;
using LeCong.AbpZeroTemplate.MultiTenancy;

namespace LeCong.AbpZeroTemplate.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}