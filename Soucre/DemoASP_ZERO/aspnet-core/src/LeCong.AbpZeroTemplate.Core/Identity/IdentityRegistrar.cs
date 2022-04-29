using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using LeCong.AbpZeroTemplate.Authentication.TwoFactor.Google;
using LeCong.AbpZeroTemplate.Authorization;
using LeCong.AbpZeroTemplate.Authorization.Roles;
using LeCong.AbpZeroTemplate.Authorization.Users;
using LeCong.AbpZeroTemplate.Editions;
using LeCong.AbpZeroTemplate.MultiTenancy;

namespace LeCong.AbpZeroTemplate.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>(options =>
                {
                    options.Tokens.ProviderMap[GoogleAuthenticatorProvider.Name] = new TokenProviderDescriptor(typeof(GoogleAuthenticatorProvider));
                })
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
