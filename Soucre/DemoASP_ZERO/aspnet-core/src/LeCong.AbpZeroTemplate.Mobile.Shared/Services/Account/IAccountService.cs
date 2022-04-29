using System.Threading.Tasks;
using LeCong.AbpZeroTemplate.ApiClient.Models;

namespace LeCong.AbpZeroTemplate.Services.Account
{
    public interface IAccountService
    {
        AbpAuthenticateModel AbpAuthenticateModel { get; set; }
        
        AbpAuthenticateResultModel AuthenticateResultModel { get; set; }
        
        Task LoginUserAsync();

        Task LogoutAsync();
    }
}
