using MyMVVM.ViewModelBase;

namespace MyMVVM.Navigation.Navigators
{
    /// <summary>
    /// The Navigator interface
    /// </summary>
    public interface INavigator
    {
        ViewModel CurrentViewModel { get; set; }
    }
}
