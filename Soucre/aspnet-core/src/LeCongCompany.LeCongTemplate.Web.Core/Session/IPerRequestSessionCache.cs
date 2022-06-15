using System.Threading.Tasks;
using LeCongCompany.LeCongTemplate.Sessions.Dto;

namespace LeCongCompany.LeCongTemplate.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
