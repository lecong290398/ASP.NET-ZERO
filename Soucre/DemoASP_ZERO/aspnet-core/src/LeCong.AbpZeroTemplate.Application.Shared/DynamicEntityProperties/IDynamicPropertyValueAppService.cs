using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using LeCong.AbpZeroTemplate.DynamicEntityProperties.Dto;

namespace LeCong.AbpZeroTemplate.DynamicEntityProperties
{
    public interface IDynamicPropertyValueAppService
    {
        Task<DynamicPropertyValueDto> Get(int id);

        Task<ListResultDto<DynamicPropertyValueDto>> GetAllValuesOfDynamicProperty(EntityDto input);

        Task Add(DynamicPropertyValueDto dto);

        Task Update(DynamicPropertyValueDto dto);

        Task Delete(int id);
    }
}
