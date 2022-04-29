using System;
using Abp.AutoMapper;
using LeCong.AbpZeroTemplate.Sessions.Dto;

namespace LeCong.AbpZeroTemplate.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}