using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.Organizations.Dto;

namespace LeCongCompany.LeCongTemplate.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}