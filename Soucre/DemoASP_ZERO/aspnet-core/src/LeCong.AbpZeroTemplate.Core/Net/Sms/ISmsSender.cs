using System.Threading.Tasks;

namespace LeCong.AbpZeroTemplate.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}