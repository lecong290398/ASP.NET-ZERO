﻿namespace LeCong.AbpZeroTemplate.Authorization.Accounts.Dto
{
    public class ResolveTenantIdInput
    {
        // An encrypted text which contains tenantId={value} string
        public string c { get; set; }
    }
}