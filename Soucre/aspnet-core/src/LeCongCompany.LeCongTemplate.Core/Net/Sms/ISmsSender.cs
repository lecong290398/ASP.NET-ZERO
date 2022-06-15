using System.Threading.Tasks;

namespace LeCongCompany.LeCongTemplate.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}