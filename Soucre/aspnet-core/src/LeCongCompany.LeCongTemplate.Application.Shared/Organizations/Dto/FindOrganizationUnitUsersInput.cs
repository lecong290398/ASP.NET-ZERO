using LeCongCompany.LeCongTemplate.Dto;

namespace LeCongCompany.LeCongTemplate.Organizations.Dto
{
    public class FindOrganizationUnitUsersInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}
