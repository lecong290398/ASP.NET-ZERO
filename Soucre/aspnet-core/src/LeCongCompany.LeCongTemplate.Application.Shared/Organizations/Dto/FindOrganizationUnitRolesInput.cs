using LeCongCompany.LeCongTemplate.Dto;

namespace LeCongCompany.LeCongTemplate.Organizations.Dto
{
    public class FindOrganizationUnitRolesInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}