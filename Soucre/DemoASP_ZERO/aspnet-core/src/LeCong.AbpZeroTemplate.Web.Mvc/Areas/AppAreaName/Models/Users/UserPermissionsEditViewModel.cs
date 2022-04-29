using Abp.AutoMapper;
using LeCong.AbpZeroTemplate.Authorization.Users;
using LeCong.AbpZeroTemplate.Authorization.Users.Dto;
using LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}