using MyMVVM.Navigation.Factory;
using MyMVVM.ViewModelBase;
using System.Windows.Input;

namespace MyMVVM.Navigation.Navigators
{
    /// <summary>
    /// Concrete basic navigator
    /// </summary>
    public class Navigator : ViewModel, INavigator
    {
        private ViewModel _currentViewModel;

        public ViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set => Set(ref _currentViewModel, value);
        }
    }
}
