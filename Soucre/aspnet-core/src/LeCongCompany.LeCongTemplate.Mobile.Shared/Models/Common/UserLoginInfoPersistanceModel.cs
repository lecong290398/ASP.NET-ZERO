﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.Sessions.Dto;

namespace LeCongCompany.LeCongTemplate.Models.Common
{
    [AutoMapFrom(typeof(UserLoginInfoDto)),
     AutoMapTo(typeof(UserLoginInfoDto))]
    public class UserLoginInfoPersistanceModel : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public string ProfilePictureId { get; set; }
    }
}