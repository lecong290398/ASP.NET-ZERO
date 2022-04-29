﻿using Abp.AutoMapper;
using LeCong.AbpZeroTemplate.MultiTenancy.Dto;

namespace LeCong.AbpZeroTemplate.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}