using System.Threading.Tasks;
using LeCongCompany.LeCongTemplate.ApiClient;
using LeCongCompany.LeCongTemplate.ApiClient.Models;
using LeCongCompany.LeCongTemplate.Sessions.Dto;

namespace LeCongCompany.LeCongTemplate.Services.Storage
{
    public interface IDataStorageService
    {
        Task StoreAccessTokenAsync(string newAccessToken);

        Task StoreAuthenticateResultAsync(AbpAuthenticateResultModel authenticateResultModel);

        AbpAuthenticateResultModel RetrieveAuthenticateResult();

        TenantInformation RetrieveTenantInfo();

        GetCurrentLoginInformationsOutput RetrieveLoginInfo();

        void ClearSessionPersistance();

        Task StoreLoginInformationAsync(GetCurrentLoginInformationsOutput loginInfo);

        Task StoreTenantInfoAsync(TenantInformation tenantInfo);
    }
}
