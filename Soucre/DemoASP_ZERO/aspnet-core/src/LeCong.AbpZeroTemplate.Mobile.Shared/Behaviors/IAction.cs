using Xamarin.Forms.Internals;

namespace LeCong.AbpZeroTemplate.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}