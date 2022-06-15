using Abp.AutoMapper;
using Abp.Organizations;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.OrganizationUnits
{
    [AutoMapFrom(typeof(OrganizationUnit))]
    public class EditOrganizationUnitModalViewModel
    {
        public long? Id { get; set; }

        public string DisplayName { get; set; }
    }
}