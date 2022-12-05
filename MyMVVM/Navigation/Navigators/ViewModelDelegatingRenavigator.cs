using MyMVVM.Navigation.Factory;
using MyMVVM.ViewModelBase;

namespace MyMVVM.Navigation.Navigators
{
    public class ViewModelDelegatingRenavigator<TViewModel> : IRenavigator where TViewModel:ViewModel
    {
        private readonly INavigator _navigator;
        private readonly CreateViewModel<TViewModel> _createViewModel;

        public ViewModelDelegatingRenavigator(INavigator navigator, CreateViewModel<TViewModel> createViewModel)
        {
            _navigator = navigator;
            _createViewModel = createViewModel;
        }

        public void Renavigate()
        {
            _navigator.CurrentViewModel = _createViewModel();
        }
    }
}
