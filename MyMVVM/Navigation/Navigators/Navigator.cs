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
        private IViewModelAbstractFactory _viewModelFactory;

        #region Конструкторы
        public Navigator(ViewModel currentViewModel, IViewModelAbstractFactory viewModelFactory)
        {
            _currentViewModel = currentViewModel;
            _viewModelFactory = viewModelFactory;
        }
        #endregion

        public ViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set => Set(ref _currentViewModel, value);
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this, _viewModelFactory);
    }
}
