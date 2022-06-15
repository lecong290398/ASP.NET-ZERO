using System;
using Abp.Notifications;
using LeCongCompany.LeCongTemplate.Dto;

namespace LeCongCompany.LeCongTemplate.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}