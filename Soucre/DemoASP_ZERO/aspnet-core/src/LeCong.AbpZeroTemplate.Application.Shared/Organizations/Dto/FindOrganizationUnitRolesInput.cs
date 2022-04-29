using LeCong.AbpZeroTemplate.Dto;

namespace LeCong.AbpZeroTemplate.Organizations.Dto
{
    public class FindOrganizationUnitRolesInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}