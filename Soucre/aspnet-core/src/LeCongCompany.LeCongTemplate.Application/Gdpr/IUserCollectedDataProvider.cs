using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using LeCongCompany.LeCongTemplate.Dto;

namespace LeCongCompany.LeCongTemplate.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
