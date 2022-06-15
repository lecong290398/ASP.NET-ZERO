using Abp;
using Abp.Domain.Services;
using System.Threading.Tasks;

namespace LeCongCompany.LeCongTemplate.Authorization.Users.Profile
{
    public interface IProfileImageService : IDomainService
    {
        Task<string> GetProfilePictureContentForUser(UserIdentifier userIdentifier);
    }
}