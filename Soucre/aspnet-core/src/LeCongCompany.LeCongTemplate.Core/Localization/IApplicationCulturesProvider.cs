using System.Globalization;

namespace LeCongCompany.LeCongTemplate.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}