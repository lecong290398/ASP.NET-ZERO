using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LeCongCompany.LeCongTemplate.Authorization.Permissions.Dto;

namespace LeCongCompany.LeCongTemplate.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
