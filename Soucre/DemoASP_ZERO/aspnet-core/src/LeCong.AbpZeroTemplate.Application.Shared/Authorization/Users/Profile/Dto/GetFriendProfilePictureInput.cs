﻿using System;
using Abp;

namespace LeCong.AbpZeroTemplate.Authorization.Users.Profile.Dto
{
    public class GetFriendProfilePictureInput
    {
        public long UserId { get; set; }

        public int? TenantId { get; set; }

        public UserIdentifier ToUserIdentifier()
        {
            return new UserIdentifier(TenantId, UserId);
        }
    }
}