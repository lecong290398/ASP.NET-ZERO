namespace LeCongCompany.LeCongTemplate.Configuration
{
    public interface IAppConfigurationWriter
    {
        void Write(string key, string value);
    }
}
