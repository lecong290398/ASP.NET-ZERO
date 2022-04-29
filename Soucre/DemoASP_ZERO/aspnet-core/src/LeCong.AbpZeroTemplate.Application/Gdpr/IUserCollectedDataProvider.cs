using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using LeCong.AbpZeroTemplate.Dto;

namespace LeCong.AbpZeroTemplate.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
