using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LeCongCompany.LeCongTemplate.Localization
{
    public static class LeCongTemplateLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    LeCongTemplateConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LeCongTemplateLocalizationConfigurer).GetAssembly(),
                        "LeCongCompany.LeCongTemplate.Localization.LeCongTemplate"
                    )
                )
            );
        }
    }
}