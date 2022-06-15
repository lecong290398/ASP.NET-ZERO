using System.Collections.Generic;
using LeCongCompany.LeCongTemplate.Editions.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}