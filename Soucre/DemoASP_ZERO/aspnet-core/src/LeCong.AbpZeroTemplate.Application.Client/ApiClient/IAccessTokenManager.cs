using System;
using System.Threading.Tasks;
using LeCong.AbpZeroTemplate.ApiClient.Models;

namespace LeCong.AbpZeroTemplate.ApiClient
{
    public interface IAccessTokenManager
    {
        string GetAccessToken();

        Task<AbpAuthenticateResultModel> LoginAsync();

        Task<string> RefreshTokenAsync();

        void Logout();

        bool IsUserLoggedIn { get; }

        bool IsRefreshTokenExpired { get; }

        AbpAuthenticateResultModel AuthenticateResult { get; set; }

        DateTime AccessTokenRetrieveTime { get; set; }
    }
}