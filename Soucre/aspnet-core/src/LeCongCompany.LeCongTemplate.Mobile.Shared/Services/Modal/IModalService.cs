using System.Threading.Tasks;
using LeCongCompany.LeCongTemplate.Views;
using Xamarin.Forms;

namespace LeCongCompany.LeCongTemplate.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
