using System.Globalization;

namespace LeCong.AbpZeroTemplate.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}