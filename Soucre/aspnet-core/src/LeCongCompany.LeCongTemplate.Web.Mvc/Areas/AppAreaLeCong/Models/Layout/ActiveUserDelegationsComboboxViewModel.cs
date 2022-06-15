using System.Collections.Generic;
using LeCongCompany.LeCongTemplate.Authorization.Delegation;
using LeCongCompany.LeCongTemplate.Authorization.Users.Delegation.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
