using MyMVVM.ViewModelBase;
using System.Windows.Input;

namespace MyMVVM.Navigation.Navigators
{
    /// <summary>
    /// The Navigator interface
    /// </summary>
    public interface INavigator
    {
        ViewModel CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
