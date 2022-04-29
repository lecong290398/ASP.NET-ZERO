using Abp.AutoMapper;
using LeCong.AbpZeroTemplate.Authorization.Roles.Dto;
using LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common;

namespace LeCong.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}