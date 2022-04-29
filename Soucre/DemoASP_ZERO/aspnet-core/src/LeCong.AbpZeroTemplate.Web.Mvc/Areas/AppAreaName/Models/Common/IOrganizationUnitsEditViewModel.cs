using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Organizations.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}