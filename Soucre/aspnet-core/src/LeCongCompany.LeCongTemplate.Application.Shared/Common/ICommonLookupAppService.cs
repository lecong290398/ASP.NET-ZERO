using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LeCongCompany.LeCongTemplate.Common.Dto;
using LeCongCompany.LeCongTemplate.Editions.Dto;

namespace LeCongCompany.LeCongTemplate.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}