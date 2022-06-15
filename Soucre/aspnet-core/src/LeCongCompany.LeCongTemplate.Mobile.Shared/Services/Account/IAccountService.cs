using System.Threading.Tasks;
using LeCongCompany.LeCongTemplate.ApiClient.Models;

namespace LeCongCompany.LeCongTemplate.Services.Account
{
    public interface IAccountService
    {
        AbpAuthenticateModel AbpAuthenticateModel { get; set; }
        
        AbpAuthenticateResultModel AuthenticateResultModel { get; set; }
        
        Task LoginUserAsync();

        Task LogoutAsync();
    }
}
