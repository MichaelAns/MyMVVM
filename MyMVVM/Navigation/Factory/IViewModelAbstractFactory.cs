using MyMVVM.ViewModelBase;

namespace MyMVVM.Navigation.Factory
{
    /// <summary>
    /// The factory responsible for the Viewmodel management logic
    /// </summary>
    public interface IViewModelAbstractFactory
    {
        public ViewModel GetViewModel(object? parameter);
    }
}
