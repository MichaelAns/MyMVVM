using MyMVVM.Navigation.Factory;
using MyMVVM.ViewModelBase;

namespace MyMVVM.Navigation.Navigators
{
    public class ViewModelFactoryRenavigator<TViewModel> : IRenavigator where TViewModel:ViewModel
    {
        public readonly INavigator _navigator;

        public ViewModelFactoryRenavigator(INavigator navigator)
        {
            _navigator = navigator;
        }

        public void Renavigate()
        {
            //_navigator.CurrentViewModel = _viewModelFactory.CreateViewModel();
        }
    }
}
