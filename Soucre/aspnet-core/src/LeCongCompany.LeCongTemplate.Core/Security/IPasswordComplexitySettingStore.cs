using System.Threading.Tasks;

namespace LeCongCompany.LeCongTemplate.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
