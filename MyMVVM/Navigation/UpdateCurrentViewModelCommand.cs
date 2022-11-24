using MyMVVM.Commands.Base;
using MyMVVM.Navigation.Factory;
using MyMVVM.Navigation.Navigators;

namespace MyMVVM.Navigation
{
    public class UpdateCurrentViewModelCommand : Command
    {
        /// <summary>
        /// The necessary navigator
        /// </summary>
        private INavigator _navigator;

        /// <summary>
        /// Viewmodel management logic
        /// </summary>
        private IViewModelFactory _viewModelFactory;

        public UpdateCurrentViewModelCommand(INavigator navigator, IViewModelFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }

       
        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter) => _navigator.CurrentViewModel = _viewModelFactory.GetViewModel(parameter);
    }
}
