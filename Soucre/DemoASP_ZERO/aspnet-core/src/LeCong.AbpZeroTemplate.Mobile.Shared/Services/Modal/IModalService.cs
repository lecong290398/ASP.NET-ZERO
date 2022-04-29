using System.Threading.Tasks;
using LeCong.AbpZeroTemplate.Views;
using Xamarin.Forms;

namespace LeCong.AbpZeroTemplate.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
