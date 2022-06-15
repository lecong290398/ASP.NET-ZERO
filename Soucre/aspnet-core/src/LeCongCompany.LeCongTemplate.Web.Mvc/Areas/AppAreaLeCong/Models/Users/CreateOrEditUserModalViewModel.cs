using System.Linq;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.Authorization.Users.Dto;
using LeCongCompany.LeCongTemplate.Security;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Common;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Users
{
    [AutoMapFrom(typeof(GetUserForEditOutput))]
    public class CreateOrEditUserModalViewModel : GetUserForEditOutput, IOrganizationUnitsEditViewModel
    {
        public bool CanChangeUserName => User.UserName != AbpUserBase.AdminUserName;

        public int AssignedRoleCount
        {
            get { return Roles.Count(r => r.IsAssigned); }
        }

        public bool IsEditMode => User.Id.HasValue;

        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }
    }
}