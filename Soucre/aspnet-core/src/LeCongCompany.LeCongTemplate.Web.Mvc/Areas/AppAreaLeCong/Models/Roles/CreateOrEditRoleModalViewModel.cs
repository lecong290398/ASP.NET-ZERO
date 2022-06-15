using Abp.AutoMapper;
using LeCongCompany.LeCongTemplate.Authorization.Roles.Dto;
using LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Common;

namespace LeCongCompany.LeCongTemplate.Web.Areas.AppAreaLeCong.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}