﻿using System.ComponentModel.DataAnnotations;

namespace LeCong.AbpZeroTemplate.Authorization.Accounts.Dto
{
    public class ImpersonateUserInput
    {
        public int? TenantId { get; set; }
    
        [Range(1, long.MaxValue)]
        public long UserId { get; set; }
    }
}
