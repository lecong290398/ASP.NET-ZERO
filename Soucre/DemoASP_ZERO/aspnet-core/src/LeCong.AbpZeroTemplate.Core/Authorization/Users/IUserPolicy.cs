using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace LeCong.AbpZeroTemplate.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
