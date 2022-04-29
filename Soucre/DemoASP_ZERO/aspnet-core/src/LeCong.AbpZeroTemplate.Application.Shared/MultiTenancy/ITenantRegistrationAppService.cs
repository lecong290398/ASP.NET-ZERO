using System.Threading.Tasks;
using Abp.Application.Services;
using LeCong.AbpZeroTemplate.Editions.Dto;
using LeCong.AbpZeroTemplate.MultiTenancy.Dto;

namespace LeCong.AbpZeroTemplate.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}