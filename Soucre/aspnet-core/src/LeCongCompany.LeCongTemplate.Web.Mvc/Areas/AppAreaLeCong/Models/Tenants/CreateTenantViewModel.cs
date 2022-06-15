using System.Collections.Generic;
using LeCongCompany.LeCongTemplate.Editions.Dto;
using LeCongCompany.LeCongTemplate.Security;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Tenants
{
    public class CreateTenantViewModel
    {
        public IReadOnlyList<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public CreateTenantViewModel(IReadOnlyList<SubscribableEditionComboboxItemDto> editionItems)
        {
            EditionItems = editionItems;
        }
    }
}