using LeCongCompany.LeCongTemplate.Models.Users;
using LeCongCompany.LeCongTemplate.ViewModels;
using Xamarin.Forms;

namespace LeCongCompany.LeCongTemplate.Views
{
    public partial class UsersView : ContentPage, IXamarinView
    {
        public UsersView()
        {
            InitializeComponent();
        }

        public async void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            await ((UsersViewModel) BindingContext).LoadMoreUserIfNeedsAsync(e.Item as UserListModel);
        }
    }
}