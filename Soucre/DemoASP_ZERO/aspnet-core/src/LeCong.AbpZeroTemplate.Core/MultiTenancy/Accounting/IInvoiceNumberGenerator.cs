using System.Threading.Tasks;
using Abp.Dependency;

namespace LeCong.AbpZeroTemplate.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}