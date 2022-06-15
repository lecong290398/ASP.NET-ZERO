using Xamarin.Forms.Internals;

namespace LeCongCompany.LeCongTemplate.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}