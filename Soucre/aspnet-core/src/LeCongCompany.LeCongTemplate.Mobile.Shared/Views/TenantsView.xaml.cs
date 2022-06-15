using LeCongCompany.LeCongTemplate.Models.Tenants;
using LeCongCompany.LeCongTemplate.ViewModels;
using Xamarin.Forms;

namespace LeCongCompany.LeCongTemplate.Views
{
    public partial class TenantsView : ContentPage, IXamarinView
    {
        public TenantsView()
        {
            InitializeComponent();
        }

        private async void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            await ((TenantsViewModel)BindingContext).LoadMoreTenantsIfNeedsAsync(e.Item as TenantListModel);
        }
    }
}