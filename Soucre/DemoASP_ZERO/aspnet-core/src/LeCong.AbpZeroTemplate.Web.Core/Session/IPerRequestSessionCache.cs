using System.Threading.Tasks;
using LeCong.AbpZeroTemplate.Sessions.Dto;

namespace LeCong.AbpZeroTemplate.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
