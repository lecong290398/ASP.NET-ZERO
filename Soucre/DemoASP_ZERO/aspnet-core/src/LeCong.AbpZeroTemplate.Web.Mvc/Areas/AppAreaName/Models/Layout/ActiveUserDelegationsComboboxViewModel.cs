using System.Collections.Generic;
using LeCong.AbpZeroTemplate.Authorization.Delegation;
using LeCong.AbpZeroTemplate.Authorization.Users.Delegation.Dto;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
