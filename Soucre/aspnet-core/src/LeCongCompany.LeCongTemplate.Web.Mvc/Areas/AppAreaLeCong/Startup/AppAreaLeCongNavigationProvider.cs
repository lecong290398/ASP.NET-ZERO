using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using LeCongCompany.LeCongTemplate.Authorization;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Startup
{
    public class AppAreaLeCongNavigationProvider : NavigationProvider
    {
        public const string MenuName = "App";

        public override void SetNavigation(INavigationProviderContext context)
        {
            var menu = context.Manager.Menus[MenuName] = new MenuDefinition(MenuName, new FixedLocalizableString("Main Menu"));

            menu
                .AddItem(new MenuItemDefinition(
                        AppAreaLeCongPageNames.Host.Dashboard,
                        L("Dashboard"),
                        url: "AppAreaLeCong/HostDashboard",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Dashboard)
                    )
                ).AddItem(new MenuItemDefinition(
                    AppAreaLeCongPageNames.Host.Tenants,
                    L("Tenants"),
                    url: "AppAreaLeCong/Tenants",
                    icon: "flaticon-list-3",
                    permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenants)
                    )
                ).AddItem(new MenuItemDefinition(
                        AppAreaLeCongPageNames.Host.Editions,
                        L("Editions"),
                        url: "AppAreaLeCong/Editions",
                        icon: "flaticon-app",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Editions)
                    )
                ).AddItem(new MenuItemDefinition(
                        AppAreaLeCongPageNames.Tenant.Dashboard,
                        L("Dashboard"),
                        url: "AppAreaLeCong/TenantDashboard",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenant_Dashboard)
                    )
                ).AddItem(new MenuItemDefinition(
                        AppAreaLeCongPageNames.Common.Administration,
                        L("Administration"),
                        icon: "flaticon-interface-8"
                    ).AddItem(new MenuItemDefinition(
                            AppAreaLeCongPageNames.Common.OrganizationUnits,
                            L("OrganizationUnits"),
                            url: "AppAreaLeCong/OrganizationUnits",
                            icon: "flaticon-map",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_OrganizationUnits)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaLeCongPageNames.Common.Roles,
                            L("Roles"),
                            url: "AppAreaLeCong/Roles",
                            icon: "flaticon-suitcase",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Roles)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaLeCongPageNames.Common.Users,
                            L("Users"),
                            url: "AppAreaLeCong/Users",
                            icon: "flaticon-users",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Users)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaLeCongPageNames.Common.Languages,
                            L("Languages"),
                            url: "AppAreaLeCong/Languages",
                            icon: "flaticon-tabs",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Languages)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaLeCongPageNames.Common.AuditLogs,
                            L("AuditLogs"),
                            url: "AppAreaLeCong/AuditLogs",
                            icon: "flaticon-folder-1",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_AuditLogs)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaLeCongPageNames.Host.Maintenance,
                            L("Maintenance"),
                            url: "AppAreaLeCong/Maintenance",
                            icon: "flaticon-lock",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Maintenance)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaLeCongPageNames.Tenant.SubscriptionManagement,
                            L("Subscription"),
                            url: "AppAreaLeCong/SubscriptionManagement",
                            icon: "flaticon-refresh",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaLeCongPageNames.Common.UiCustomization,
                            L("VisualSettings"),
                            url: "AppAreaLeCong/UiCustomization",
                            icon: "flaticon-medical",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_UiCustomization)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppAreaLeCongPageNames.Common.WebhookSubscriptions,
                            L("WebhookSubscriptions"),
                            url: "AppAreaLeCong/WebhookSubscription",
                            icon: "flaticon2-world",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_WebhookSubscription)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AppAreaLeCongPageNames.Common.DynamicProperties,
                            L("DynamicProperties"),
                            url: "AppAreaLeCong/DynamicProperty",
                            icon: "flaticon-interface-8",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_DynamicProperties)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AppAreaLeCongPageNames.Host.Settings,
                            L("Settings"),
                            url: "AppAreaLeCong/HostSettings",
                            icon: "flaticon-settings",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Settings)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AppAreaLeCongPageNames.Tenant.Settings,
                            L("Settings"),
                            url: "AppAreaLeCong/Settings",
                            icon: "flaticon-settings",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Tenant_Settings)
                        )
                    )
                ).AddItem(new MenuItemDefinition(
                        AppAreaLeCongPageNames.Common.DemoUiComponents,
                        L("DemoUiComponents"),
                        url: "AppAreaLeCong/DemoUiComponents",
                        icon: "flaticon-shapes",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_DemoUiComponents)
                    )
                )
                .AddItem(new MenuItemDefinition(
                    AppAreaLeCongPageNames.Tenant.PhoneBook,
                    L("PhoneBook"),
                    url: "AppAreaLeCong/PhoneBook",
                    icon: "flaticon-shapes",
                     permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_PhoneBook)
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, LeCongTemplateConsts.LocalizationSourceName);
        }
    }
}
