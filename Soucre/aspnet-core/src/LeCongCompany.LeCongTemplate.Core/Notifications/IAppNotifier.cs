using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Abp.Localization;
using Abp.Notifications;
using LeCongCompany.LeCongTemplate.Authorization.Users;
using LeCongCompany.LeCongTemplate.MultiTenancy;

namespace LeCongCompany.LeCongTemplate.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task GdprDataPrepared(UserIdentifier user, Guid binaryObjectId);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);

        Task SendMessageAsync(UserIdentifier user, LocalizableString localizableMessage, IDictionary<string, object> localizableMessageData = null, NotificationSeverity severity = NotificationSeverity.Info);

        Task TenantsMovedToEdition(UserIdentifier user, string sourceEditionName, string targetEditionName);

        Task SomeUsersCouldntBeImported(UserIdentifier user, string fileToken, string fileType, string fileName);
    }
}
