using System;
using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.Sessions.Dto;

namespace LeCongCompany.LeCongTemplate.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}