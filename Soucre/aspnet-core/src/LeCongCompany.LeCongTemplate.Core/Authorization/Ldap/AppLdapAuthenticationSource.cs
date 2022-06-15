using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using LeCongCompany.LeCongTemplate.Authorization.Users;
using LeCongCompany.LeCongTemplate.MultiTenancy;

namespace LeCongCompany.LeCongTemplate.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}