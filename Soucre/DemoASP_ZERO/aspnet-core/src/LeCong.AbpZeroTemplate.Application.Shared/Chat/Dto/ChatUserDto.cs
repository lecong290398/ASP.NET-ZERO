using System;
using Abp.Application.Services.Dto;
using LeCong.AbpZeroTemplate.Friendships;

namespace LeCong.AbpZeroTemplate.Chat.Dto
{
    public class ChatUserDto : EntityDto<long>
    {
        public int? TenantId { get; set; }

        public Guid? ProfilePictureId { get; set; }

        public string UserName { get; set; }

        public string TenancyName { get; set; }

        public int UnreadMessageCount { get; set; }

        public bool IsOnline { get; set; }

        public FriendshipState State { get; set; }
    }
}