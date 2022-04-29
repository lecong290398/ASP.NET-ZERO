using Abp.AutoMapper;
using LeCong.AbpZeroTemplate.Organizations.Dto;

namespace LeCong.AbpZeroTemplate.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}