using LeCongCompany.LeCongTemplate.Dto;

namespace LeCongCompany.LeCongTemplate.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }

        public bool ExcludeCurrentUser { get; set; }
    }
}