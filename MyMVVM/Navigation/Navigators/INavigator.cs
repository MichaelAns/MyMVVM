using MyMVVM.ViewModelBase;
using System.Windows.Input;

namespace MyMVVM.Navigation.Navigators
{
    public interface INavigator
    {
        ViewModel CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
