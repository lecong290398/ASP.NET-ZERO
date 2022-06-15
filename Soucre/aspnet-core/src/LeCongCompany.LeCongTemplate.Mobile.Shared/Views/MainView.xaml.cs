using Xamarin.Forms;

namespace LeCongCompany.LeCongTemplate.Views
{
    public partial class MainView : FlyoutPage, IXamarinView
    {
        public MainView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
