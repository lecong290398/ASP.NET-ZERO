using System.Threading.Tasks;
using Abp.Dependency;

namespace LeCongCompany.LeCongTemplate.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}