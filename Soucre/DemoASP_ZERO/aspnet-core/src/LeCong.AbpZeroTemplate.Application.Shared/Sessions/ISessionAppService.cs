using System.Threading.Tasks;
using Abp.Application.Services;
using LeCong.AbpZeroTemplate.Sessions.Dto;

namespace LeCong.AbpZeroTemplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
