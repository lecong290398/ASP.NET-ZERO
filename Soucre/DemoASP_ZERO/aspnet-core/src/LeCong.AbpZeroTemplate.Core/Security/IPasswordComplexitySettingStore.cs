using System.Threading.Tasks;

namespace LeCong.AbpZeroTemplate.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
